// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �û���ϵ.
/// </summary>
public class UserRelation
{
    /// <summary>
    /// �û���ϵ״̬��1:δ��ע 2:�ѹ�ע 3:����ע 4:�����ע.
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }
}

/// <summary>
/// �û���ϵ��Ӧ���.
/// </summary>
public class UserRelationResponse
{
    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("mid")]
    public int UserId { get; set; }

    /// <summary>
    /// ��עʱ�䣬δ��ע��Ϊ0.
    /// </summary>
    [JsonPropertyName("mtime")]
    public long FollowTime { get; set; }

    /// <summary>
    /// ��ע����,0-δ��ע��2-�ѹ�ע��6-�ѻ��أ�128-����.
    /// </summary>
    [JsonPropertyName("attribute")]
    public int Type { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ�ر��ע��0-��1-��.
    /// </summary>
    [JsonPropertyName("special")]
    public int IsSpecialFollow { get; set; }

    /// <summary>
    /// �Ƿ��ע.
    /// </summary>
    /// <returns>��ע���.</returns>
    public bool IsFollow() => Type is 2 or 6;
}

