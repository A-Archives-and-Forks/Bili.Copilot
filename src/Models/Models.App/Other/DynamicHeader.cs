// Copyright (c) Bili Copilot. All rights reserved.

namespace Bili.Copilot.Models.App.Other;

/// <summary>
/// ��̬������ͷ.
/// </summary>
public sealed class DynamicHeader
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicHeader"/> class.
    /// </summary>
    /// <param name="isVideo">�Ƿ�Ϊ��Ƶ��̬.</param>
    /// <param name="title">ͷ����.</param>
    public DynamicHeader(
        bool isVideo,
        string title)
    {
        IsVideo = isVideo;
        Title = title;
    }

    /// <summary>
    /// �Ƿ�Ϊ��Ƶ��̬.
    /// </summary>
    public bool IsVideo { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    public string Title { get; set; }

    /// <inheritdoc/>
    public override bool Equals(object obj) => obj is DynamicHeader header && Title == header.Title;

    /// <inheritdoc/>
    public override int GetHashCode() => Title.GetHashCode();
}

