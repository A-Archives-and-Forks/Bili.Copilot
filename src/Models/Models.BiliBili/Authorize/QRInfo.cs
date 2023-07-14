// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��ά����Ϣ.
/// </summary>
public class QRInfo
{
    /// <summary>
    /// ��ȡ��ά�����ݵĵ�ַ.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// ��֤��.
    /// </summary>
    [JsonPropertyName("auth_code")]
    public string AuthCode { get; set; }
}

