// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ������Ϣ.
/// </summary>
public class ReplyMessageResponse
{
    /// <summary>
    /// ƫ��ָ��.
    /// </summary>
    [JsonPropertyName("cursor")]
    public MessageCursor Cursor { get; set; }

    /// <summary>
    /// ��Ŀ�б�.
    /// </summary>
    [JsonPropertyName("items")]
    public List<ReplyMessageItem> Items { get; set; }

    /// <summary>
    /// �ϴβ鿴ʱ��.
    /// </summary>
    [JsonPropertyName("last_view_at")]
    public long LastViewTime { get; set; }
}

/// <summary>
/// ������Ϣ��Ŀ.
/// </summary>
public class ReplyMessageItem : MessageItem
{
    /// <summary>
    /// ���۵��û�.
    /// </summary>
    [JsonPropertyName("user")]
    public MessageUser User { get; set; }

    /// <summary>
    /// ������Ϣ����.
    /// </summary>
    [JsonPropertyName("item")]
    public ReplyMessageItemDetail Item { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("counts")]
    public int Counts { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ��������.
    /// </summary>
    [JsonPropertyName("is_multi")]
    public int IsMultiple { get; set; }

    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("reply_time")]
    public long ReplyTime { get; set; }
}

/// <summary>
/// ������Ϣ��Ŀ����.
/// </summary>
public class ReplyMessageItemDetail : AtMessageItemDetail
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("desc")]
    public string Description { get; set; }
}

