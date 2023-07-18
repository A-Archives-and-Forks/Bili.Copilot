// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ��˿�б���Ӧ���.
/// </summary>
public class RelatedUserResponse
{
    /// <summary>
    /// ��˿�б�.
    /// </summary>
    [JsonPropertyName("list")]
    public List<RelatedUser> UserList { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("total")]
    public int TotalCount { get; set; }
}

/// <summary>
/// ��ص��û������ڷ�˿���ע.
/// </summary>
public class RelatedUser
{
    /// <summary>
    /// �û�ID.
    /// </summary>
    [JsonPropertyName("mid")]
    public long Mid { get; set; }

    /// <summary>
    /// ��ע��ʽ��0-δ��ע��2-�ѹ�ע��3-�ѻ���.
    /// </summary>
    [JsonPropertyName("attribute")]
    public int Attribute { get; set; }

    /// <summary>
    /// ��Ϊ��˿/��ע�û���ʱ��.
    /// </summary>
    [JsonPropertyName("mtime")]
    public int StartTime { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ�ر��ע��0-�ǣ�1-��.
    /// </summary>
    [JsonPropertyName("special")]
    public int Special { get; set; }

    /// <summary>
    /// �û���.
    /// </summary>
    [JsonPropertyName("uname")]
    public string Name { get; set; }

    /// <summary>
    /// ͷ��.
    /// </summary>
    [JsonPropertyName("face")]
    public string Avatar { get; set; }

    /// <summary>
    /// ����ǩ��.
    /// </summary>
    [JsonPropertyName("sign")]
    public string Sign { get; set; }

    /// <summary>
    /// ��Ա��Ϣ.
    /// </summary>
    [JsonPropertyName("vip")]
    public Vip Vip { get; set; }
}

/// <summary>
/// ��ע����.
/// </summary>
public class RelatedTag
{
    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("tagid")]
    public int TagId { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// ˵��.
    /// </summary>
    [JsonPropertyName("tip")]
    public string Tip { get; set; }

    /// <inheritdoc/>
    public override bool Equals(object obj) => obj is RelatedTag tag && TagId == tag.TagId;

    /// <inheritdoc/>
    public override int GetHashCode() => 1948533646 + TagId.GetHashCode();
}

