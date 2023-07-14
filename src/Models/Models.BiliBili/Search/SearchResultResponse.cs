// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ���������Ӧ.
/// </summary>
public class SearchResultResponse
{
    /// <summary>
    /// ׷��Id.
    /// </summary>
    [JsonPropertyName("trackid")]
    public string TrackId { get; set; }

    /// <summary>
    /// ҳ��.
    /// </summary>
    [JsonPropertyName("pages")]
    public int PageNumber { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; set; }

    /// <summary>
    /// �����ؼ���.
    /// </summary>
    [JsonPropertyName("keyword")]
    public string Keyword { get; set; }
}

/// <summary>
/// �ۺ��������.
/// </summary>
public class ComprehensiveSearchResultResponse : SearchResultResponse
{
    /// <summary>
    /// ��ģ���б�.
    /// </summary>
    [JsonPropertyName("nav")]
    public List<SearchSubModule> SubModuleList { get; set; }

    /// <summary>
    /// ��Ŀ�б�.
    /// </summary>
    [JsonPropertyName("item")]
    public List<VideoSearchItem> ItemList { get; set; }
}

/// <summary>
/// ������ģ���������.
/// </summary>
/// <typeparam name="T">��������.</typeparam>
public class SubModuleSearchResultResponse<T> : SearchResultResponse
{
    /// <summary>
    /// ��Ŀ�б�.
    /// </summary>
    [JsonPropertyName("items")]
    public List<T> ItemList { get; set; }
}

/// <summary>
/// ֱ���������.
/// </summary>
public class LiveSearchResultResponse : SearchResultResponse
{
    /// <summary>
    /// ֱ������.
    /// </summary>
    [JsonPropertyName("live_room")]
    public LiveRoomSearchResult RoomResult { get; set; }
}

/// <summary>
/// ������ģ��.
/// </summary>
public class SearchSubModule
{
    /// <summary>
    /// ��ʾ����.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// �����������.
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; set; }

    /// <summary>
    /// ��ҳ��.
    /// </summary>
    [JsonPropertyName("pages")]
    public int PageCount { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }
}

/// <summary>
/// ֱ�����������.
/// </summary>
public class LiveRoomSearchResult
{
    /// <summary>
    /// ��Ŀ�б�.
    /// </summary>
    [JsonPropertyName("items")]
    public List<LiveSearchItem> Items { get; set; }
}

