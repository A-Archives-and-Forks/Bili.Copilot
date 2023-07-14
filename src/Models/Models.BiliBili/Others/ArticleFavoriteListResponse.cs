// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �����ղؼ���Ӧ���.
/// </summary>
public class ArticleFavoriteListResponse
{
    /// <summary>
    /// ����Ŀ��.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// �����б�.
    /// </summary>
    [JsonPropertyName("items")]
    public List<FavoriteArticleItem> Items { get; set; }
}

/// <summary>
/// �ղص�����.
/// </summary>
public class FavoriteArticleItem
{
    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ���ͼƬ.
    /// </summary>
    [JsonPropertyName("banner_url")]
    public string Banner { get; set; }

    /// <summary>
    /// ����������.
    /// </summary>
    [JsonPropertyName("name")]
    public string PublisherName { get; set; }

    /// <summary>
    /// ͼƬ����.
    /// </summary>
    [JsonPropertyName("image_urls")]
    public List<string> Images { get; set; }

    /// <summary>
    /// ��Ҫ.
    /// </summary>
    [JsonPropertyName("summary")]
    public string Summary { get; set; }

    /// <summary>
    /// �ղ�ʱ��.
    /// </summary>
    [JsonPropertyName("favorite_time")]
    public int CollectTime { get; set; }

    /// <summary>
    /// ��ַ.
    /// </summary>
    [JsonPropertyName("uri")]
    public string Url { get; set; }

    /// <summary>
    /// ����������.
    /// </summary>
    [JsonPropertyName("up_mid")]
    public int PublisherId { get; set; }

    /// <summary>
    /// �����ı�.
    /// </summary>
    [JsonPropertyName("badge")]
    public string BadgeText { get; set; }
}

