// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ������Ӱ�ӵĶ�����ǩҳ.
/// </summary>
public class PgcTab
{
    /// <summary>
    /// ��ǩҳId.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ��ָ�������.
    /// </summary>
    [JsonPropertyName("link")]
    public string Link { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}

