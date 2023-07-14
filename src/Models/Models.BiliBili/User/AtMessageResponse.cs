// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// @�ҵ���Ϣ.
/// </summary>
public class AtMessageResponse
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
    public List<AtMessageItem> Items { get; set; }
}

/// <summary>
/// @�ҵ���Ϣ��Ŀ.
/// </summary>
public class AtMessageItem : MessageItem
{
    /// <summary>
    /// �û�.
    /// </summary>
    [JsonPropertyName("user")]
    public MessageUser User { get; set; }

    /// <summary>
    /// ��Ϣ����.
    /// </summary>
    [JsonPropertyName("item")]
    public AtMessageItemDetail Item { get; set; }

    /// <summary>
    /// @�ҵ�ʱ��.
    /// </summary>
    [JsonPropertyName("at_time")]
    public long AtTime { get; set; }
}

/// <summary>
/// @�ҵ���Ϣ��Ŀ����.
/// </summary>
public class AtMessageItemDetail : MessageItemDetail
{
    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("subject_id")]
    public long SubjectId { get; set; }

    /// <summary>
    /// Դ����Id.
    /// </summary>
    [JsonPropertyName("source_id")]
    public long SourceId { get; set; }

    /// <summary>
    /// Դ����.
    /// </summary>
    [JsonPropertyName("source_content")]
    public string SourceContent { get; set; }

    /// <summary>
    /// At���˵���Ϣ.
    /// </summary>
    [JsonPropertyName("at_details")]
    public List<MessageUser> AtDetails { get; set; }
}

