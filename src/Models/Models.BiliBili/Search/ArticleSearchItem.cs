// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ����������Ŀ.
/// </summary>
public class ArticleSearchItem : SearchItemBase
{
    /// <summary>
    /// �û���.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("desc")]
    public string Description { get; set; }

    /// <summary>
    /// �û���.
    /// </summary>
    [JsonPropertyName("mid")]
    public int UserId { get; set; }

    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ͼƬ����.
    /// </summary>
    [JsonPropertyName("image_urls")]
    public List<string> CoverUrls { get; set; }

    /// <summary>
    /// �Ķ�����.
    /// </summary>
    [JsonPropertyName("view")]
    public int ViewCount { get; set; }

    /// <summary>
    /// ���޴���.
    /// </summary>
    [JsonPropertyName("like")]
    public int LikeCount { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("reply")]
    public int ReplyCount { get; set; }

    /// <summary>
    /// �����ı�.
    /// </summary>
    [JsonPropertyName("badge")]
    public string BadgeText { get; set; }
}

