// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ���俨Ƭ.
/// </summary>
public class LiveRoomCard : LiveRoomBase
{
    /// <summary>
    /// ֱ����Id.
    /// </summary>
    [JsonPropertyName("id")]
    public long RoomId { get; set; }

    /// <summary>
    /// ��������Id.
    /// </summary>
    [JsonPropertyName("area_id")]
    public long AreaId { get; set; }

    /// <summary>
    /// ��ʾ������.
    /// </summary>
    [JsonPropertyName("area_name")]
    public string AreaName { get; set; }

    /// <summary>
    /// ������Id.
    /// </summary>
    [JsonPropertyName("parent_area_id")]
    public long ParentAreaId { get; set; }

    /// <summary>
    /// ����������.
    /// </summary>
    [JsonPropertyName("parent_area_name")]
    public string ParentAreaName { get; set; }

    /// <summary>
    /// ��������ı���ָ�û���.
    /// </summary>
    [JsonPropertyName("cover_left_style")]
    public LiveCoverContent CoverLeftContent { get; set; }

    /// <summary>
    /// �����Ҳ��ı���ָ�ۿ�����.
    /// </summary>
    [JsonPropertyName("cover_right_style")]
    public LiveCoverContent CoverRightContent { get; set; }

    /// <summary>
    /// �����б�.
    /// </summary>
    [JsonPropertyName("feedback")]
    public List<LiveFeedback> Feedback { get; set; }

    /// <summary>
    /// ���.
    /// </summary>
    [JsonPropertyName("index")]
    public long Index { get; set; }

    /// <summary>
    /// �Ƿ����ط���.0-�����أ�1-����.
    /// </summary>
    [JsonPropertyName("is_hide_feedback")]
    public int IsHideFeedback { get; set; }

    /// <summary>
    /// ����������ʽ.
    /// </summary>
    public class LiveCoverContent
    {
        /// <summary>
        /// �����ı�.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    /// <summary>
    /// ����.
    /// </summary>
    public class LiveFeedback
    {
        /// <summary>
        /// ����.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// ������.
        /// </summary>
        [JsonPropertyName("subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// ����.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// ���ɼ���.
        /// </summary>
        [JsonPropertyName("reasons")]
        public List<LiveFeedbackReason> Reasons { get; set; }

        /// <summary>
        /// ֱ����������.
        /// </summary>
        public class LiveFeedbackReason
        {
            /// <summary>
            /// ��ʶ��.
            /// </summary>
            [JsonPropertyName("id")]
            public long Id { get; set; }

            /// <summary>
            /// ����.
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; }

            /// <summary>
            /// Id����.
            /// </summary>
            [JsonPropertyName("id_type")]
            public string IdType { get; set; }
        }
    }
}

