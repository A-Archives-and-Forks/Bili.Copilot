// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// δ����Ϣ���.
/// </summary>
public class UnreadMessage
{
    /// <summary>
    /// @�ҵ�.
    /// </summary>
    [JsonPropertyName("at")]
    public int At { get; set; }

    /// <summary>
    /// ������Ϣ.
    /// </summary>
    [JsonPropertyName("chat")]
    public int Chat { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("like")]
    public int Like { get; set; }

    /// <summary>
    /// �ظ�.
    /// </summary>
    [JsonPropertyName("reply")]
    public int Reply { get; set; }

    /// <summary>
    /// ϵͳ��Ϣ.
    /// </summary>
    [JsonPropertyName("sys_msg")]
    public int SystemMessage { get; set; }
}

