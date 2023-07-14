// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �ּ�������Ϣ�������û�Ͷ�ң����ޣ��ղص���Ϣ��.
/// </summary>
public class EpisodeInteraction
{
    /// <summary>
    /// Ͷ����.
    /// </summary>
    [JsonPropertyName("coin_number")]
    public int CoinNumber { get; set; }

    /// <summary>
    /// �Ƿ��ղ�.
    /// </summary>
    [JsonPropertyName("favorite")]
    public int IsFavorite { get; set; }

    /// <summary>
    /// �Ƿ����.
    /// </summary>
    [JsonPropertyName("like")]
    public int IsLike { get; set; }
}

