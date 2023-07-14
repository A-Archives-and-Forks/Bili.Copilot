// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ������Ϣ���û�.
/// </summary>
public class MessageUser
{
    /// <summary>
    /// �û�ID.
    /// </summary>
    [JsonPropertyName("mid")]
    public long UserId { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ��˿��0-���ǣ�1-��.
    /// </summary>
    [JsonPropertyName("fans")]
    public int IsFans { get; set; }

    /// <summary>
    /// �û���.
    /// </summary>
    [JsonPropertyName("nickname")]
    public string UserName { get; set; }

    /// <summary>
    /// ͷ��.
    /// </summary>
    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }

    /// <summary>
    /// �Ƿ��ע�˸��û�.
    /// </summary>
    [JsonPropertyName("follow")]
    public bool IsFollow { get; set; }
}

