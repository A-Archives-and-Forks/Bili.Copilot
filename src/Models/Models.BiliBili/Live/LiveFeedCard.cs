// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��Դ��Ƭ.
/// </summary>
public class LiveFeedCard
{
    /// <summary>
    /// ֱ����Ƭ����.
    /// </summary>
    [JsonPropertyName("card_type")]
    public string CardType { get; set; }

    /// <summary>
    /// ��Ƭ����.
    /// </summary>
    [JsonPropertyName("card_data")]
    public LiveFeedCardData CardData { get; set; }
}

/// <summary>
/// ֱ��Դ��Ƭ����.
/// </summary>
public class LiveFeedCardData
{
    /// <summary>
    /// ����б�.
    /// </summary>
    [JsonPropertyName("banner_v1")]
    public LiveFeedBannerList Banners { get; set; }

    /// <summary>
    /// ���ŷ���.
    /// </summary>
    [JsonPropertyName("area_entrance_v1")]
    public LiveFeedHotAreaList HotAreas { get; set; }

    /// <summary>
    /// �ҹ�ע���û��б�.
    /// </summary>
    [JsonPropertyName("my_idol_v1")]
    public LiveFeedFollowUserList FollowList { get; set; }

    /// <summary>
    /// ֱ����Ƭ.
    /// </summary>
    [JsonPropertyName("small_card_v1")]
    public LiveRoomCard LiveCard { get; set; }
}

