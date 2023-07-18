// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �Ժ��ٿ���Ӧ���.
/// </summary>
public class ViewLaterResponse
{
    /// <summary>
    /// ��Ƶ�б�.
    /// </summary>
    [JsonPropertyName("list")]
    public List<ViewLaterVideo> List { get; set; }

    /// <summary>
    /// �Ժ��ٿ���Ƶ��.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }
}

