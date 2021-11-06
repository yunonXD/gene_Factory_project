Shader "Custom/SWater"
{
    Properties
    {
        _BumpMap("BumpMap", 2D) = "Bump"{}
        _WaveSpeed("Wave Speed", float) = 0.05
        _WavePower("Wave Power", float) = 0.2
        _WaveTilling("Wave Tilling", float) = 25

        _CubeMap("CubeMap", Cube) = ""{}

        _SpacPow("Spacular Power", float) = 2
    }

        SubShader
        {
            Tags { "RenderType" = "Opaque" }
            LOD 200

            GrabPass{}

            CGPROGRAM
            #pragma surface surf WLight vertex:vert noambient noshadow 

            #pragma target 3.0

            sampler2D _BumpMap;
            float _WaveSpeed;
            float _WavePower;
            float _WaveTilling;

            samplerCUBE _CubeMap;

            sampler2D _GrabTexture;
            float _SpacPow;

            float dotData;

            struct Input
            {
                float2 uv_BumpMap;
                float3 worldRefl;
                float4 screenPos;
                float3 viewDir;
                INTERNAL_DATA
            };

            void vert(inout appdata_full v)
            {
                v.vertex.y = sin(abs(v.texcoord.x * 2 - 1) * _WaveTilling + _Time.y) * _WavePower;
            }

            void surf(Input IN, inout SurfaceOutput o)
            {
                float4 nor1 = tex2D(_BumpMap, IN.uv_BumpMap + float2(_Time.y * _WaveSpeed, 0));
                float4 nor2 = tex2D(_BumpMap, IN.uv_BumpMap - float2(_Time.y * _WaveSpeed, 0));
                o.Normal = UnpackNormal((nor1 + nor2) * 0.5);

                float4 sky = texCUBE(_CubeMap, WorldReflectionVector(IN, o.Normal));
                float4 refrection = tex2D(_GrabTexture, (IN.screenPos / IN.screenPos.a).xy + o.Normal.xy * 0.03);

                dotData = pow(saturate(1 - dot(o.Normal, IN.viewDir)), 0.6);
                float3 water = lerp(refrection, sky, dotData).rgb;

                o.Albedo = water;
            }

            float4 LightingWLight(SurfaceOutput s, float3 lightDIr, float3 viewDir, float atten)
            {
                float3 refVec = s.Normal * dot(s.Normal, viewDir) * 2 - viewDir;
                refVec = normalize(refVec);

                float spcr = lerp(0, pow(saturate(dot(refVec, lightDIr)),256), dotData) * _SpacPow;

                return float4(s.Albedo + spcr.rrr,1);
            }
            ENDCG
        }
            FallBack "Diffuse"
}