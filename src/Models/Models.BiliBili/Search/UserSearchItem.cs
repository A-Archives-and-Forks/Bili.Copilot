// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �û�������Ŀ.
/// </summary>
public class UserSearchItem : SearchItemBase
{
    /// <summary>
    /// ǩ��/���˽���.
    /// </summary>
    [JsonPropertyName("sign")]
    public string Sign { get; set; }

    /// <summary>
    /// ��˿��.
    /// </summary>
    [JsonPropertyName("fans")]
    public int FollowerCount { get; set; }

    /// <summary>
    /// �ȼ�.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }

    /// <summary>
    /// ���Ա��Ϣ.
    /// </summary>
    [JsonPropertyName("vip")]
    public Vip Vip { get; set; }

    /// <summary>
    /// �Ƿ���UP��.
    /// </summary>
    [JsonPropertyName("is_up")]
    public bool IsUp { get; set; }

    /// <summary>
    /// Ͷ����.
    /// </summary>
    [JsonPropertyName("archives")]
    public int ArchiveCount { get; set; }

    /// <summary>
    /// ֱ����Id.
    /// </summary>
    [JsonPropertyName("roomid")]
    public int RoomId { get; set; }

    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("mid")]
    public int UserId { get; set; }

    /// <summary>
    /// ֱ������ַ.
    /// </summary>
    [JsonPropertyName("live_link")]
    public string LiveLink { get; set; }

    /// <summary>
    /// �û���ϵ.
    /// </summary>
    [JsonPropertyName("relation")]
    public UserRelation Relation { get; set; }
}

