// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��Ƶ�ղظ�����Ӧ.
/// </summary>
public class VideoFavoriteGalleryResponse
{
    /// <summary>
    /// �ղؼ��б�.
    /// </summary>
    [JsonPropertyName("space_infos")]
    public List<FavoriteFolder> FavoriteFolderList { get; set; }

    /// <summary>
    /// Ĭ���ղؼ�.
    /// </summary>
    [JsonPropertyName("default_folder")]
    public VideoFavoriteListResponse DefaultFavoriteList { get; set; }
}

/// <summary>
/// ��ƵĬ���ղؼ�.
/// </summary>
public class VideoFavoriteListResponse
{
    /// <summary>
    /// �ղؼ���Ϣ.
    /// </summary>
    [JsonPropertyName("folder_detail")]
    public FavoriteListDetail Detail { get; set; }

    /// <summary>
    /// �ղؼ���Ϣ.
    /// </summary>
    [JsonPropertyName("info")]
    public FavoriteListDetail Information { get; set; }

    /// <summary>
    /// �ղؼе�ý���б�.
    /// </summary>
    [JsonPropertyName("medias")]
    public List<FavoriteMedia> Medias { get; set; }

    /// <summary>
    /// �Ƿ��и���.
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
}

/// <summary>
/// �ղؼ�����.
/// </summary>
public class FavoriteListDetail
{
    /// <summary>
    /// �ղؼ�����ID.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// �ղؼ�ԭʼID.
    /// </summary>
    [JsonPropertyName("fid")]
    public long OriginId { get; set; }

    /// <summary>
    /// �û�ID.
    /// </summary>
    [JsonPropertyName("mid")]
    public long Mid { get; set; }

    /// <summary>
    /// �ղؼб���.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// �����ղؼе��û���Ϣ.
    /// </summary>
    [JsonPropertyName("upper")]
    public PublisherInfo Publisher { get; set; }

    /// <summary>
    /// ˵��/��ע.
    /// </summary>
    [JsonPropertyName("intro")]
    public string Description { get; set; }

    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("ctime")]
    public int CreateTime { get; set; }

    /// <summary>
    /// �ղ�ʱ��.
    /// </summary>
    [JsonPropertyName("mtime")]
    public int CollectTime { get; set; }

    /// <summary>
    /// �ղؼ��ղ�״̬��1-���ղأ�0-δ�ղ�.
    /// </summary>
    [JsonPropertyName("fav_state")]
    public int FavoriteState { get; set; }

    /// <summary>
    /// ������Ŀ.
    /// </summary>
    [JsonPropertyName("media_count")]
    public int MediaCount { get; set; }

    /// <summary>
    /// �鿴����.
    /// </summary>
    [JsonPropertyName("view_count")]
    public int ViewCount { get; set; }
}

/// <summary>
/// �ղؼ�ý��.
/// </summary>
public class FavoriteMedia
{
    /// <summary>
    /// ý��Id.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// ý�����ͣ�2-��Ƶ��12-��Ƶ��21-��Ƶ�ϼ�.
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ý��˵���ı�.
    /// </summary>
    [JsonPropertyName("intro")]
    public string Description { get; set; }

    /// <summary>
    /// ҳ��.
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }

    /// <summary>
    /// ʱ��.
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("upper")]
    public PublisherInfo Publisher { get; set; }

    /// <summary>
    /// �Ƿ���Ч��0-��Ч��1-��Ч.
    /// </summary>
    [JsonPropertyName("attr")]
    public int IsValid { get; set; }

    /// <summary>
    /// �û���������.
    /// </summary>
    [JsonPropertyName("cnt_info")]
    public FavoriteMediaStat Stat { get; set; }

    /// <summary>
    /// ��ַ.
    /// </summary>
    [JsonPropertyName("link")]
    public string Link { get; set; }

    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("ctime")]
    public long CreateTime { get; set; }

    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("pubtime")]
    public long PublishTime { get; set; }

    /// <summary>
    /// �ղ�ʱ��.
    /// </summary>
    [JsonPropertyName("fav_time")]
    public long FavoriteTime { get; set; }

    /// <summary>
    /// Bv Id.
    /// </summary>
    [JsonPropertyName("bvid")]
    public string BvId { get; set; }

    /// <summary>
    /// ������Ϣ.
    /// </summary>
    [JsonPropertyName("ugc")]
    public FavoriteUgcInformation UgcInformation { get; set; }
}

/// <summary>
/// �ղؼ�ý���û���������.
/// </summary>
public class FavoriteMediaStat
{
    /// <summary>
    /// �ղ���.
    /// </summary>
    [JsonPropertyName("collect")]
    public int FavoriteCount { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("play")]
    public int PlayCount { get; set; }

    /// <summary>
    /// ��Ļ��.
    /// </summary>
    [JsonPropertyName("danmaku")]
    public int DanmakuCount { get; set; }
}

/// <summary>
/// �ղؼ�UGC������Ϣ.
/// </summary>
public class FavoriteUgcInformation
{
    /// <summary>
    /// �׸���P Id.
    /// </summary>
    [JsonPropertyName("first_cid")]
    public int FirstCid { get; set; }
}

/// <summary>
/// �ղؼз���.
/// </summary>
public class FavoriteFolder
{
    /// <summary>
    /// �ղؼ���������Id.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// ý���б�.
    /// </summary>
    [JsonPropertyName("mediaListResponse")]
    public FavoriteMediaList MediaList { get; set; }
}

/// <summary>
/// �ղؼ�ý���б�.
/// </summary>
public class FavoriteMediaList
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// ý���б�.
    /// </summary>
    [JsonPropertyName("list")]
    public List<FavoriteListDetail> List { get; set; }

    /// <summary>
    /// �Ƿ��и���.
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
}

