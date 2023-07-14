// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// �ҵ���Ϣ.
/// </summary>
public class MyInfo
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
    /// �û�ǩ��.
    /// </summary>
    [JsonPropertyName("sign")]
    public string Sign { get; set; }

    /// <summary>
    /// Ӳ����.
    /// </summary>
    [JsonPropertyName("coins")]
    public double Coins { get; set; }

    /// <summary>
    /// ���գ���ʽΪYYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("birthday")]
    public string Birthday { get; set; }

    /// <summary>
    /// ͷ��.
    /// </summary>
    [JsonPropertyName("face")]
    public string Avatar { get; set; }

    /// <summary>
    /// �Ա�0-���ܣ�1-���ԣ�2-Ů��.
    /// </summary>
    [JsonPropertyName("sex")]
    public int Sex { get; set; }

    /// <summary>
    /// �˻��ȼ�.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }

    /// <summary>
    /// ���״̬��0-������1-����.
    /// </summary>
    [JsonPropertyName("silence")]
    public int IsBlocking { get; set; }

    /// <summary>
    /// ���Ա��Ϣ.
    /// </summary>
    [JsonPropertyName("vip")]
    public Vip VIP { get; set; }
}

/// <summary>
/// ���Ա��Ϣ.
/// </summary>
public class Vip
{
    /// <summary>
    /// ���Ա���ͣ�0-�ǻ�Ա��1-�¶ȴ��Ա��2-��ȼ����ϴ��Ա.
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// ��Ա״̬��0-�ޣ�1-��.
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// ��Ա����ʱ�䣨����Unixʱ�����.
    /// </summary>
    [JsonPropertyName("due_date")]
    public long DueDate { get; set; }
}

