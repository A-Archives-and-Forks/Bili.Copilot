// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ���׽�����Ϣ����.
/// </summary>
public class LiveMessage
{
}

/// <summary>
/// ֱ����Ļ��Ϣ.
/// </summary>
public class LiveDanmakuMessage : LiveMessage
{
    /// <summary>
    /// �ı�.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// �û���.
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// �û��ȼ�.
    /// </summary>
    public string Level { get; set; }

    /// <summary>
    /// �ȼ���ɫ.
    /// </summary>
    public string LevelColor { get; set; }

    /// <summary>
    /// �û�ͷ��.
    /// </summary>
    public string UserTitle { get; set; }

    /// <summary>
    /// ��Ա�ı�.
    /// </summary>
    public string VipText { get; set; }

    /// <summary>
    /// ѫ����.
    /// </summary>
    public string MedalName { get; set; }

    /// <summary>
    /// ѫ�µȼ�.
    /// </summary>
    public string MedalLevel { get; set; }

    /// <summary>
    /// ѫ����ɫ.
    /// </summary>
    public string MedalColor { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ����Ա.
    /// </summary>
    public bool IsAdmin { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ��ү.
    /// </summary>
    public bool IsVip { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ�����ү.
    /// </summary>
    public bool IsBigVip { get; set; }

    /// <summary>
    /// �Ƿ��л���.
    /// </summary>
    public bool HasMedal { get; set; }

    /// <summary>
    /// �Ƿ���ͷ��.
    /// </summary>
    public bool HasTitle { get; set; }

    /// <summary>
    /// �û�����ɫ.
    /// </summary>
    public string UserNameColor { get; set; }

    /// <summary>
    /// ������ɫ.
    /// </summary>
    public string ContentColor { get; set; }
}

/// <summary>
/// ֱ��������Ϣ.
/// </summary>
public class LiveGiftMessage : LiveMessage
{
    /// <summary>
    /// �û���.
    /// </summary>
    [JsonPropertyName("uname")]
    public string UserName { get; set; }

    /// <summary>
    /// ������.
    /// </summary>
    [JsonPropertyName("gift_name")]
    public string GiftName { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    [JsonPropertyName("total_num")]
    public string TotalNumber { get; set; }

    /// <summary>
    /// ����Id.
    /// </summary>
    [JsonPropertyName("gift_id")]
    public int GiftId { get; set; }

    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("uid")]
    public string UserId { get; set; }

    /// <summary>
    /// ��ͼ.
    /// </summary>
    [JsonPropertyName("gif")]
    public string Gif { get; set; }
}

/// <summary>
/// ֱ����ӭ��Ϣ.
/// </summary>
public class LiveWelcomeMessage : LiveMessage
{
    /// <summary>
    /// ��ͼ.
    /// </summary>
    [JsonPropertyName("uname")]
    public string UserName { get; set; }

    /// <summary>
    /// �û�Id.
    /// </summary>
    [JsonPropertyName("uid")]
    public string UserId { get; set; }

    /// <summary>
    /// �Ƿ�Ϊ��ү.
    /// </summary>
    [JsonPropertyName("vip")]
    public int Vip { get; set; }
}

