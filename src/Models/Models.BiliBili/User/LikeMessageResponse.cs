// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ���޵���Ϣ.
/// </summary>
public class LikeMessageResponse
{
    /// <summary>
    /// ������Ϣ.
    /// </summary>
    [JsonPropertyName("lastest")]
    public LikeMesageLatest Latest { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("total")]
    public LikeMessageTotal Total { get; set; }
}

/// <summary>
/// ���µĵ�����Ϣ.
/// </summary>
public class LikeMesageLatest
{
    /// <summary>
    /// ��Ϣ�б�.
    /// </summary>
    [JsonPropertyName("items")]
    public List<LikeMessageItem> Items { get; set; }

    /// <summary>
    /// �ϴβ鿴ʱ��.
    /// </summary>
    [JsonPropertyName("last_view_at")]
    public int LastViewTime { get; set; }
}

/// <summary>
/// ������Ϣ��Ŀ.
/// </summary>
public class LikeMessageItem : MessageItem
{
    /// <summary>
    /// ����Ϣ�ڰ����ĵ�������Ϣ.
    /// </summary>
    [JsonPropertyName("users")]
    public List<MessageUser> Users { get; set; }

    /// <summary>
    /// ������Ϣ����.
    /// </summary>
    [JsonPropertyName("item")]
    public LikeMessageItemDetail Item { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("counts")]
    public int Count { get; set; }

    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("like_time")]
    public long LikeTime { get; set; }

    /// <summary>
    /// �Ƿ���������Ϣ��Ӧ���ڸ�ֵ��.
    /// </summary>
    public bool IsLatest { get; set; }
}

/// <summary>
/// ������Ϣ����.
/// </summary>
public class LikeMessageItemDetail : MessageItemDetail
{
    /// <summary>
    /// ��ĿId.
    /// </summary>
    [JsonPropertyName("item_id")]
    public long ItemId { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("desc")]
    public string Description { get; set; }
}

/// <summary>
/// ��ʷ������Ϣ.
/// </summary>
public class LikeMessageTotal
{
    /// <summary>
    /// ƫ��ָ��.
    /// </summary>
    [JsonPropertyName("cursor")]
    public MessageCursor Cursor { get; set; }

    /// <summary>
    /// ��Ϣ�б�.
    /// </summary>
    [JsonPropertyName("items")]
    public List<LikeMessageItem> Items { get; set; }
}

