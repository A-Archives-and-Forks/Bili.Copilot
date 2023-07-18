// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �û��ռ���Ϣ��Ӧ���.
/// </summary>
public class UserSpaceResponse
{
    /// <summary>
    /// �û���Ϣ.
    /// </summary>
    [JsonPropertyName("card")]
    public UserSpaceInformation User { get; set; }

    /// <summary>
    /// ֱ����Ϣ.
    /// </summary>
    [JsonPropertyName("live")]
    public UserSpaceLive Live { get; set; }

    /// <summary>
    /// ��Ƶ��.
    /// </summary>
    [JsonPropertyName("archive")]
    public UserSpaceVideoSet VideoSet { get; set; }

    /// <summary>
    /// ���¼�.
    /// </summary>
    [JsonPropertyName("article")]
    public UserSpaceArticleSet ArticleSet { get; set; }
}

/// <summary>
/// �û��ռ���Ϣ.
/// </summary>
public class UserSpaceInformation
{
    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("mid")]
    public string UserId { get; set; }

    /// <summary>
    /// �û���.
    /// </summary>
    [JsonPropertyName("name")]
    public string UserName { get; set; }

    /// <summary>
    /// �Ա�.
    /// </summary>
    [JsonPropertyName("sex")]
    public string Sex { get; set; }

    /// <summary>
    /// ͷ��.
    /// </summary>
    [JsonPropertyName("face")]
    public string Avatar { get; set; }

    /// <summary>
    /// ��˿��.
    /// </summary>
    [JsonPropertyName("fans")]
    public int FollowerCount { get; set; }

    /// <summary>
    /// ��ע��.
    /// </summary>
    [JsonPropertyName("attention")]
    public int FollowCount { get; set; }

    /// <summary>
    /// ����ǩ��.
    /// </summary>
    [JsonPropertyName("sign")]
    public string Sign { get; set; }

    /// <summary>
    /// �ȼ���Ϣ.
    /// </summary>
    [JsonPropertyName("level_info")]
    public UserSpaceLevelInformation LevelInformation { get; set; }

    /// <summary>
    /// ���Ա��Ϣ.
    /// </summary>
    [JsonPropertyName("vip")]
    public Vip Vip { get; set; }

    /// <summary>
    /// ��ϵ.
    /// </summary>
    [JsonPropertyName("relation")]
    public UserRelation Relation { get; set; }

    /// <summary>
    /// ������Ϣ.
    /// </summary>
    [JsonPropertyName("likes")]
    public UserSpaceLikeInformation LikeInformation { get; set; }
}

/// <summary>
/// �û��ռ������Ϣ.
/// </summary>
public class UserSpaceLikeInformation
{
    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("like_num")]
    public int LikeCount { get; set; }
}

/// <summary>
/// �û��ռ�ĵȼ���Ϣ.
/// </summary>
public class UserSpaceLevelInformation
{
    /// <summary>
    /// �û���ǰ�ȼ�.
    /// </summary>
    [JsonPropertyName("current_level")]
    public int CurrentLevel { get; set; }

    /// <summary>
    /// ��ǰ����ֵ.
    /// </summary>
    [JsonPropertyName("current_exp")]
    public int CurrentExperience { get; set; }

    /// <summary>
    /// �ﵽ��һ�ȼ����辭��ֵ.
    /// </summary>
    [JsonPropertyName("next_exp")]
    public string NextExperience { get; set; }
}

/// <summary>
/// �û��ռ��ֱ����Ϣ.
/// </summary>
public class UserSpaceLive
{
    /// <summary>
    /// ֱ����״̬��0-δ������1-����ֱ��.
    /// </summary>
    [JsonPropertyName("roomStatus")]
    public int RoomStatus { get; set; }

    /// <summary>
    /// ֱ��״̬��0-δ������1-����ֱ����2-�ֲ�.
    /// </summary>
    [JsonPropertyName("liveStatus")]
    public int LiveStatus { get; set; }

    /// <summary>
    /// ֱ����ַ.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary>
    /// ֱ������.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ���߹ۿ�����.
    /// </summary>
    [JsonPropertyName("online")]
    public int ViewerCount { get; set; }

    /// <summary>
    /// ֱ����Id.
    /// </summary>
    [JsonPropertyName("roomid")]
    public int RoomId { get; set; }
}

/// <summary>
/// �û��ռ���Ƶ��.
/// </summary>
public class UserSpaceVideoSet
{
    /// <summary>
    /// ��Ƶ����.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// ��Ƶ�б�.
    /// </summary>
    [JsonPropertyName("item")]
    public List<UserSpaceVideoItem> List { get; set; }
}

/// <summary>
/// �û��ռ���Ƶ��Ŀ.
/// </summary>
public class UserSpaceVideoItem
{
    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("tname")]
    public string PartitionName { get; set; }

    /// <summary>
    /// ��Ƶ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ��ƵId.
    /// </summary>
    [JsonPropertyName("param")]
    public string Id { get; set; }

    /// <summary>
    /// Ŀ������.
    /// </summary>
    [JsonPropertyName("goto")]
    public string Goto { get; set; }

    /// <summary>
    /// ʱ��.
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ������Ƶ.
    /// </summary>
    [JsonPropertyName("is_cooperation")]
    public bool IsCooperation { get; set; }

    /// <summary>
    /// �Ƿ�ΪPGC����.
    /// </summary>
    [JsonPropertyName("is_pgc")]
    public bool IsPgc { get; set; }

    /// <summary>
    /// �Ƿ�Ϊֱ���ط�.
    /// </summary>
    [JsonPropertyName("is_live_playback")]
    public bool IsLivePlayback { get; set; }

    /// <summary>
    /// ���Ŵ���.
    /// </summary>
    [JsonPropertyName("play")]
    public int PlayCount { get; set; }

    /// <summary>
    /// ��Ļ��.
    /// </summary>
    [JsonPropertyName("danmaku")]
    public int DanmakuCount { get; set; }

    /// <summary>
    /// ����ʱ��.
    /// </summary>
    [JsonPropertyName("ctime")]
    public int CreateTime { get; set; }

    /// <summary>
    /// ����������.
    /// </summary>
    [JsonPropertyName("author")]
    public string PublisherName { get; set; }

    /// <summary>
    /// Bv Id.
    /// </summary>
    [JsonPropertyName("bvid")]
    public string Bvid { get; set; }

    /// <summary>
    /// �׸���P��Id.
    /// </summary>
    [JsonPropertyName("first_cid")]
    public int FirstCid { get; set; }
}

/// <summary>
/// �û��ռ����¼�.
/// </summary>
public class UserSpaceArticleSet
{
    /// <summary>
    /// ���¸���.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// �����б�.
    /// </summary>
    [JsonPropertyName("item")]
    public List<Article> List { get; set; }
}

