// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��ҳ�Ƽ���Ϣ.
/// </summary>
public class HomeRecommendInfo
{
    /// <summary>
    /// ���ص��Ƽ���Ƭ��Ϣ�б�.
    /// </summary>
    [JsonPropertyName("items")]
    public List<RecommendCard> Items { get; set; }
}

