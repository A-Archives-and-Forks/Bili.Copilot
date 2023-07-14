// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �ղؼ��б���Ӧ.
/// </summary>
public class FavoriteListResponse
{
    /// <summary>
    /// �ղؼ�����.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// �ղؼ��б�.
    /// </summary>
    [JsonPropertyName("list")]
    public List<FavoriteMeta> List { get; set; }
}

/// <summary>
/// �ղؼ�Ԫ����.
/// </summary>
public class FavoriteMeta
{
    /// <summary>
    /// �ղؼ�����Id.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// �ղؼ�ԭʼId.
    /// </summary>
    [JsonPropertyName("fid")]
    public long FolderId { get; set; }

    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("mid")]
    public long UserId { get; set; }

    /// <summary>
    /// �ղؼб���.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ��ѯ����Ƶ�Ƿ��ڸ��ղؼ��ڣ�0-�����ڣ�1-����.
    /// </summary>
    [JsonPropertyName("fav_state")]
    public int FavoriteState { get; set; }

    /// <summary>
    /// ý����Ŀ.
    /// </summary>
    [JsonPropertyName("media_count")]
    public int MediaCount { get; set; }
}

