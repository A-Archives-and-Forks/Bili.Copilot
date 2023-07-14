// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��Դ���ŷ���.
/// </summary>
public class LiveFeedHotArea : LiveFeedExtraCardBase
{
    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("area_v2_id")]
    public long AreaId { get; set; }

    /// <summary>
    /// ������Id.
    /// </summary>
    [JsonPropertyName("area_v2_parent_id")]
    public long ParentAreaId { get; set; }

    /// <summary>
    /// ��ǩ����.
    /// </summary>
    [JsonPropertyName("tag_type")]
    public long TagType { get; set; }
}

/// <summary>
/// ֱ��Դ���ŷ����б�.
/// </summary>
public class LiveFeedHotAreaList
{
    /// <summary>
    /// �б�����.
    /// </summary>
    [JsonPropertyName("list")]
    public List<LiveFeedHotArea> List { get; set; }
}

