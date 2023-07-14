// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��Դ�Ƽ����ҹ�ע��ֱ����.
/// </summary>
public class LiveFeedRoom : LiveRoomBase
{
    /// <summary>
    /// ֱ����Id.
    /// </summary>
    [JsonPropertyName("roomid")]
    public long RoomId { get; set; }

    /// <summary>
    /// �û���.
    /// </summary>
    [JsonPropertyName("uname")]
    public string UserName { get; set; }

    /// <summary>
    /// �û�ͷ��.
    /// </summary>
    [JsonPropertyName("face")]
    public string UserAvatar { get; set; }

    /// <summary>
    /// ֱ����ʼʱ��.
    /// </summary>
    [JsonPropertyName("live_time")]
    public long LiveStartTime { get; set; }

    /// <summary>
    /// ��ʾ����Id.
    /// </summary>
    [JsonPropertyName("area")]
    public string DisplayAreaId { get; set; }

    /// <summary>
    /// ��ʾ������.
    /// </summary>
    [JsonPropertyName("area_name")]
    public string DisplayAreaName { get; set; }

    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("area_v2_id")]
    public long AreaId { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("area_v2_name")]
    public string AreaName { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("area_v2_parent_name")]
    public string ParentAreaName { get; set; }

    /// <summary>
    /// ������Id.
    /// </summary>
    [JsonPropertyName("area_v2_parent_id")]
    public long ParentAreaId { get; set; }

    /// <summary>
    /// ֱ����ǩ��.
    /// </summary>
    [JsonPropertyName("live_tag_name")]
    public string LiveTagName { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ�ر��ע��0-��1-��.
    /// </summary>
    [JsonPropertyName("special_attention")]
    public int SpecialAttention { get; set; }

    /// <summary>
    /// �Ƿ�ٷ���֤��0-��1-��.
    /// </summary>
    [JsonPropertyName("official_verify")]
    public int OfficialVerify { get; set; }
}

/// <summary>
/// ֱ��Դ��ע�û��б�.
/// </summary>
public class LiveFeedFollowUserList
{
    /// <summary>
    /// �б�����.
    /// </summary>
    [JsonPropertyName("list")]
    public List<LiveFeedRoom> List { get; set; }
}

