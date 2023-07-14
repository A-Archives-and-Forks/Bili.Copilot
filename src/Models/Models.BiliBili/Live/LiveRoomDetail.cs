// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��������.
/// </summary>
public class LiveRoomDetail
{
    /// <summary>
    /// ������Ϣ.
    /// </summary>
    [JsonPropertyName("room_info")]
    public LiveRoomInformation RoomInformation { get; set; }

    /// <summary>
    /// ê����Ϣ.
    /// </summary>
    [JsonPropertyName("anchor_info")]
    public LiveAnchorInformation AnchorInformation { get; set; }
}

/// <summary>
/// ֱ������Ϣ.
/// </summary>
public class LiveRoomInformation
{
    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("uid")]
    public long UserId { get; set; }

    /// <summary>
    /// ֱ����Id.
    /// </summary>
    [JsonPropertyName("room_id")]
    public int RoomId { get; set; }

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
    /// ��ǩ.
    /// </summary>
    [JsonPropertyName("tags")]
    public string Tags { get; set; }

    /// <summary>
    /// �����ı�.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// ���߹ۿ�����.
    /// </summary>
    [JsonPropertyName("online")]
    public int ViewerCount { get; set; }

    /// <summary>
    /// ֱ��״̬��0-δ������1-����ֱ����2-�ֲ�.
    /// </summary>
    [JsonPropertyName("live_status")]
    public int LiveStatus { get; set; }

    /// <summary>
    /// ֱ����ʼʱ��.
    /// </summary>
    [JsonPropertyName("live_start_time")]
    public int LiveStartTime { get; set; }

    /// <summary>
    /// ֱ������״̬��0-δ�����1-�ѷ��.
    /// </summary>
    [JsonPropertyName("lock_status")]
    public int LockStatus { get; set; }

    /// <summary>
    /// ���ʱ��.
    /// </summary>
    [JsonPropertyName("lock_time")]
    public int LockTime { get; set; }

    /// <summary>
    /// ����״̬��0-δ���أ�1-������.
    /// </summary>
    [JsonPropertyName("hidden_status")]
    public int HiddenStatus { get; set; }

    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("hidden_time")]
    public int HiddenTime { get; set; }

    /// <summary>
    /// ��������Id.
    /// </summary>
    [JsonPropertyName("area_id")]
    public int AreaId { get; set; }

    /// <summary>
    /// ������������.
    /// </summary>
    [JsonPropertyName("area_name")]
    public string AreaName { get; set; }

    /// <summary>
    /// ������Id.
    /// </summary>
    [JsonPropertyName("parent_area_id")]
    public int ParentAreaId { get; set; }

    /// <summary>
    /// ����������.
    /// </summary>
    [JsonPropertyName("parent_area_name")]
    public string ParentAreaName { get; set; }

    /// <summary>
    /// �ؼ�֡����ͼ��.
    /// </summary>
    [JsonPropertyName("keyframe")]
    public string Keyframe { get; set; }

    /// <summary>
    /// �ر��ע���ͣ�0-���ر��ע��1-�ر��ע.
    /// </summary>
    [JsonPropertyName("special_type")]
    public int SpecialFollowType { get; set; }
}

/// <summary>
/// ֱ����ê����Ϣ.
/// </summary>
public class LiveAnchorInformation
{
    /// <summary>
    /// ����������Ϣ.
    /// </summary>
    [JsonPropertyName("base_info")]
    public LiveUserBasicInformation UserBasicInformation { get; set; }

    /// <summary>
    /// ֱ���ȼ���Ϣ.
    /// </summary>
    [JsonPropertyName("live_info")]
    public LiveLevelInformation LevelInformation { get; set; }

    /// <summary>
    /// ֱ����ע��Ϣ.
    /// </summary>
    [JsonPropertyName("relation_info")]
    public LiveRelationInformation RelationInformation { get; set; }

    /// <summary>
    /// ѫ����Ϣ.
    /// </summary>
    [JsonPropertyName("metal_info")]
    public LiveMedalInformation MedalInformation { get; set; }
}

/// <summary>
/// ֱ���û�������Ϣ.
/// </summary>
public class LiveUserBasicInformation
{
    /// <summary>
    /// �û���.
    /// </summary>
    [JsonPropertyName("uname")]
    public string UserName { get; set; }

    /// <summary>
    /// �û�ͷ��.
    /// </summary>
    [JsonPropertyName("face")]
    public string Avatar { get; set; }

    /// <summary>
    /// �Ա�.
    /// </summary>
    [JsonPropertyName("gender")]
    public string Gender { get; set; }
}

/// <summary>
/// ֱ���ȼ���Ϣ.
/// </summary>
public class LiveLevelInformation
{
    /// <summary>
    /// �ȼ�.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }
}

/// <summary>
/// ֱ����ע��Ϣ.
/// </summary>
public class LiveRelationInformation
{
    /// <summary>
    /// ��ע����.
    /// </summary>
    [JsonPropertyName("attention")]
    public int AttentionCount { get; set; }
}

/// <summary>
/// ֱ��ѫ����Ϣ.
/// </summary>
public class LiveMedalInformation
{
    /// <summary>
    /// ѫ����.
    /// </summary>
    [JsonPropertyName("medal_name")]
    public string Name { get; set; }

    /// <summary>
    /// ѫ��Id.
    /// </summary>
    [JsonPropertyName("medal_id")]
    public int Id { get; set; }

    /// <summary>
    /// ��˿���ֲ������ж�����ȡ��ѫ�µķ�˿��.
    /// </summary>
    [JsonPropertyName("fansclub")]
    public int FansClub { get; set; }
}

