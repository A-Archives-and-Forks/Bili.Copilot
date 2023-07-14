// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��Ƶ���������Ŀ.
/// </summary>
public class VideoSearchItem : SearchItemBase
{
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

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("author")]
    public string Author { get; set; }

    /// <summary>
    /// ˵���ı�.
    /// </summary>
    [JsonPropertyName("desc")]
    public string Description { get; set; }

    /// <summary>
    /// ʱ��.
    /// </summary>
    [JsonPropertyName("duration")]
    public string Duration { get; set; }

    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("mid")]
    public int UserId { get; set; }

    /// <summary>
    /// ͷ��.
    /// </summary>
    [JsonPropertyName("face")]
    public string Avatar { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("share")]
    public ShareData Share { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    public class ShareData
    {
        /// <summary>
        /// ����.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// ��Ƶ����.
        /// </summary>
        [JsonPropertyName("video")]
        public Video Video { get; set; }
    }

    /// <summary>
    /// ��Ƶ��������.
    /// </summary>
    public class Video
    {
        /// <summary>
        /// BV Id.
        /// </summary>
        [JsonPropertyName("bvid")]
        public string BvId { get; set; }

        /// <summary>
        /// ��P Id.
        /// </summary>
        [JsonPropertyName("cid")]
        public int Cid { get; set; }

        /// <summary>
        /// ������.
        /// </summary>
        [JsonPropertyName("short_link")]
        public string ShortLink { get; set; }
    }
}

