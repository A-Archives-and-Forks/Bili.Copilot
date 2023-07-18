// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �Ƽ���Ƭ�Ķ���.
/// </summary>
public class RecommendCard
{
    /// <summary>
    /// ��Ƭ����.
    /// </summary>
    [JsonPropertyName("card_type")]
    public string CardType { get; set; }

    /// <summary>
    /// ����Ƭ�ĳ���.
    /// </summary>
    [JsonPropertyName("card_goto")]
    public string CardGoto { get; set; }

    /// <summary>
    /// ��Ƭ����.
    /// </summary>
    [JsonPropertyName("args")]
    public RecommendCardArgs CardArgs { get; set; }

    /// <summary>
    /// ƫ��ֵ��ʶ��.
    /// </summary>
    [JsonPropertyName("idx")]
    public long Index { get; set; }

    /// <summary>
    /// �����Ĳ˵����б�.
    /// </summary>
    [JsonPropertyName("three_point_v2")]
    public List<RecommendContextMenuItem> ContextMenuItems { get; set; }

    /// <summary>
    /// ��Ҫ���ŵ�����.
    /// </summary>
    [JsonPropertyName("goto")]
    public string Goto { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// ������ַ.
    /// </summary>
    [JsonPropertyName("uri")]
    public string NavigateUri { get; set; }

    /// <summary>
    /// ��Ƶ�򷬾��Id.
    /// </summary>
    [JsonPropertyName("param")]
    public string Parameter { get; set; }

    /// <summary>
    /// ���Ų���.
    /// </summary>
    [JsonPropertyName("player_args")]
    public PlayerArgs PlayerArgs { get; set; }

    /// <summary>
    /// �������ı�.
    /// </summary>
    [JsonPropertyName("cover_left_text_2")]
    public string PlayCountText { get; set; }

    /// <summary>
    /// ״̬���ı���������Ƶ��˵�ǵ�Ļ�������ڷ�����˵�ǵ�����.
    /// </summary>
    [JsonPropertyName("cover_left_text_3")]
    public string SubStatusText { get; set; }

    /// <summary>
    /// ʱ���ı�.
    /// </summary>
    [JsonPropertyName("cover_left_text_1")]
    public string DurationText { get; set; }

    /// <summary>
    /// �Ƽ�ԭ��.
    /// </summary>
    [JsonPropertyName("top_rcmd_reason")]
    public string RecommendReason { get; set; }

    /// <summary>
    /// �Ƿ���Բ��ţ�1-����.
    /// </summary>
    [JsonPropertyName("can_play")]
    public int CanPlay { get; set; }

    /// <summary>
    /// ˵���ı�.
    /// </summary>
    [JsonPropertyName("desc")]
    public string Description { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("mask")]
    public RecommendCardMask Mask { get; set; }
}

/// <summary>
/// �Ƽ���Ƭ�Ĳ���.
/// </summary>
public class RecommendCardArgs
{
    /// <summary>
    /// ������Id.
    /// </summary>
    [JsonPropertyName("up_id")]
    public int PublisherId { get; set; }

    /// <summary>
    /// ����������.
    /// </summary>
    [JsonPropertyName("up_name")]
    public string PublisherName { get; set; }

    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("rid")]
    public int PartitionId { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("rname")]
    public string PartitionName { get; set; }

    /// <summary>
    /// �ӷ���Id.
    /// </summary>
    [JsonPropertyName("tid")]
    public int SubPartitionId { get; set; }

    /// <summary>
    /// �ӷ�������.
    /// </summary>
    [JsonPropertyName("tname")]
    public string SubPartitionName { get; set; }

    /// <summary>
    /// ��ƵAid.
    /// </summary>
    [JsonPropertyName("aid")]
    public int Aid { get; set; }
}

/// <summary>
/// ����������.
/// </summary>
public class PlayerArgs
{
    /// <summary>
    /// ��Ƶ��Aid.
    /// </summary>
    [JsonPropertyName("aid")]
    public int Aid { get; set; }

    /// <summary>
    /// ��Ƶ��һ����P��Id.
    /// </summary>
    [JsonPropertyName("cid")]
    public int Cid { get; set; }

    /// <summary>
    /// ��Ƶ���ͣ�һ��Ϊav.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// ��Ƶʱ�� (��).
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
}

/// <summary>
/// �Ƽ���Ƶ�������Ĳ˵�����.
/// </summary>
public class RecommendContextMenuItem
{
    /// <summary>
    /// ��ʾ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// �˵������͡�watch_later:�Ժ��ٿ�. feedback:����. dislike:��ϲ��.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("subtitle")]
    public string Subtitle { get; set; }

    /// <summary>
    /// ԭ���б�.
    /// </summary>
    [JsonPropertyName("reasons")]
    public List<RecommendDislikeReason> Reasons { get; set; }
}

/// <summary>
/// �Ƽ���Ƶ�Ĳ�ϲ��ԭ��.
/// </summary>
public class RecommendDislikeReason
{
    /// <summary>
    /// ԭ���ʶ��.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ��ʾ���ı�.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// ��ʾ�ı�.
    /// </summary>
    [JsonPropertyName("toast")]
    public string Tip { get; set; }
}

/// <summary>
/// �Ƽ���Ƭ����������.
/// </summary>
public class RecommendCardMask
{
    /// <summary>
    /// �Ƽ���Ƭ��ͷ��.
    /// </summary>
    [JsonPropertyName("avatar")]
    public RecommendAvatar Avatar { get; set; }
}

/// <summary>
/// �Ƽ���Ƭ��ͷ��.
/// </summary>
public class RecommendAvatar
{
    /// <summary>
    /// ͷ��.
    /// </summary>
    [JsonPropertyName("cover")]
    public string Cover { get; set; }

    /// <summary>
    /// �û���.
    /// </summary>
    [JsonPropertyName("Text")]
    public string UserName { get; set; }

    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("up_id")]
    public int UserId { get; set; }
}

