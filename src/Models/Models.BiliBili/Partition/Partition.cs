// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��������.
/// </summary>
public class Partition
{
    /// <summary>
    /// �����ı�ʶ��.
    /// </summary>
    [JsonPropertyName("tid")]
    public int Tid { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// ����ͼ��.
    /// </summary>
    [JsonPropertyName("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// ����ָ�������.
    /// </summary>
    /// <remarks>
    /// ������ָ������ƶ��˵���ת���ӣ������������������֧����ת.
    /// </remarks>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    [JsonPropertyName("children")]
    public List<Partition> Children { get; set; }

    /// <summary>
    /// �Ƿ��Ƕ�������.
    /// </summary>
    [JsonPropertyName("is_bangumi")]
    public int IsBangumi { get; set; }

    /// <summary>
    /// �жϸ÷����Ƿ���Ҫ��ʾ.
    /// </summary>
    /// <remarks>
    /// ���ַ�������H5ҳ�����ʽ���֣����ַ����ǹ�棬�˴�����ʾ����ƵΪ���ĳ������.
    /// </remarks>
    /// <returns>�����Ƿ���Ҫ��ʾ.</returns>
    public bool IsNeedToShow()
    {
        var needToShow = !string.IsNullOrEmpty(Uri) &&
            Uri.StartsWith("bilibili") &&
            Uri.Contains("region/") &&
            Children != null &&
            Children.Count > 0;
        return needToShow;
    }

    /// <inheritdoc/>
    public override bool Equals(object obj) => obj is Partition partition && Tid == partition.Tid;

    /// <inheritdoc/>
    public override int GetHashCode() => -2122499778 + Tid.GetHashCode();
}

