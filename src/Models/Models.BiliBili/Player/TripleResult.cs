// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// һ���������.
/// </summary>
public class TripleResult
{
    /// <summary>
    /// �Ƿ����.
    /// </summary>
    [JsonPropertyName("like")]
    public bool IsLike { get; set; }

    /// <summary>
    /// �Ƿ�Ͷ��.
    /// </summary>
    [JsonPropertyName("coin")]
    public bool IsCoin { get; set; }

    /// <summary>
    /// �Ƿ��ղ�.
    /// </summary>
    [JsonPropertyName("fav")]
    public bool IsFavorite { get; set; }

    /// <summary>
    /// Ͷ�Ҹ���.
    /// </summary>
    [JsonPropertyName("multiply")]
    public int CoinNumber { get; set; }
}

