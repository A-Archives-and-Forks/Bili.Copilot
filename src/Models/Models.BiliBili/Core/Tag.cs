// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��ǩ����.
/// </summary>
public class Tag
{
    /// <summary>
    /// ��ǩID.
    /// </summary>
    [JsonPropertyName("tid")]
    public int TagId { get; set; }

    /// <summary>
    /// ��ǩ��.
    /// </summary>
    [JsonPropertyName("tname")]
    public string TagName { get; set; }

    /// <summary>
    /// �����ӷ���ID.
    /// </summary>
    [JsonPropertyName("rid")]
    public int SubPartitionId { get; set; }

    /// <summary>
    /// �����ӷ�������.
    /// </summary>
    [JsonPropertyName("rname")]
    public string SubPartitionName { get; set; }

    /// <summary>
    /// ����������ID.
    /// </summary>
    [JsonPropertyName("reid")]
    public int PartitionId { get; set; }

    /// <summary>
    /// ��������������.
    /// </summary>
    [JsonPropertyName("rename")]
    public string PartitionName { get; set; }
}

