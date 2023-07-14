// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �ӷ������Ͷ���.
/// </summary>
public class SubPartition
{
    /// <summary>
    /// �Ƽ���Ƶ�б�.
    /// </summary>
    [JsonPropertyName("recommend")]
    public List<PartitionVideo> RecommendVideos { get; set; }

    /// <summary>
    /// �µ���Ƶ�б�.
    /// </summary>
    [JsonPropertyName("new")]
    public List<PartitionVideo> NewVideos { get; set; }

    /// <summary>
    /// ����ˢ�µı�ʶ��.
    /// </summary>
    [JsonPropertyName("ctop")]
    public int TopOffsetId { get; set; }

    /// <summary>
    /// ����ˢ�µı�ʶ��.
    /// </summary>
    [JsonPropertyName("cbottom")]
    public int BottomOffsetId { get; set; }
}

/// <summary>
/// �ӷ������Ƽ�ģ��.
/// </summary>
public class SubPartitionRecommend : SubPartition
{
    /// <summary>
    /// ���.
    /// </summary>
    [JsonPropertyName("banner")]
    public RecommendBanner Banner { get; set; }

    /// <summary>
    /// �Ƽ��б��µĺ������.
    /// </summary>
    public class RecommendBanner
    {
        /// <summary>
        /// ������.
        /// </summary>
        [JsonPropertyName("top")]
        public List<PartitionBanner> TopBanners { get; set; }
    }
}

/// <summary>
/// �����ӷ���.
/// </summary>
public class SubPartitionDefault : SubPartition
{
    /// <summary>
    /// ��Ƶ��ǩ.
    /// </summary>
    [JsonPropertyName("top_tag")]
    public List<Tag> TopTags { get; set; }
}

