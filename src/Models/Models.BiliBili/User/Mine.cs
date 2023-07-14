// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �ҵĻ�������.
/// </summary>
public class Mine
{
    /// <summary>
    /// �û�ID.
    /// </summary>
    [JsonPropertyName("mid")]
    public int Mid { get; set; }

    /// <summary>
    /// �û���.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// �û�ͷ��.
    /// </summary>
    [JsonPropertyName("face")]
    public string Avatar { get; set; }

    /// <summary>
    /// Ӳ����.
    /// </summary>
    [JsonPropertyName("coin")]
    public double CoinNumber { get; set; }

    /// <summary>
    /// B����.
    /// </summary>
    [JsonPropertyName("bcoin")]
    public double BcoinCount { get; set; }

    /// <summary>
    /// �Ա�0-���ܣ�1-���ԣ�2-Ů��.
    /// </summary>
    [JsonPropertyName("sex")]
    public int Sex { get; set; }

    /// <summary>
    /// �ȼ�.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }

    /// <summary>
    /// ��̬��.
    /// </summary>
    [JsonPropertyName("dynamic")]
    public int DynamicCount { get; set; }

    /// <summary>
    /// ��ע��.
    /// </summary>
    [JsonPropertyName("following")]
    public int FollowCount { get; set; }

    /// <summary>
    /// ��˿��.
    /// </summary>
    [JsonPropertyName("follower")]
    public int FollowerCount { get; set; }
}

