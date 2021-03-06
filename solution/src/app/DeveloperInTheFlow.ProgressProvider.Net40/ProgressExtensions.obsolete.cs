﻿namespace DeveloperInTheFlow.ProgressProvider
{
    using System;

    /// <summary>
    ///     Extension methods for the <see cref="IProgress{T}"/> interface.
    /// </summary>
    public static partial class ProgressExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Reports a progress update.
        /// </summary>
        /// <param name="progress">
        ///     The object being extended.
        /// </param>
        /// <param name="message">
        ///     The message of the updated progress.
        /// </param>
        [Obsolete("Use generic version of IProgressReport")]
        public static void Report(
            this IProgress<IProgressReport> progress,
            string message)
        {
            progress.Report(new ProgressReport(message));
        }

        /// <summary>
        ///     Reports a progress update.
        /// </summary>
        /// <param name="progress">
        ///     The object being extended.
        /// </param>
        /// <param name="message">
        ///     The message of the updated progress.
        /// </param>
        /// <param name="progressValue">
        ///     The current progress from [0, <paramref name="progressMaximumValue"/>].
        /// </param>
        /// <param name="progressMaximumValue">
        ///     The maximum progress value.
        /// </param>
        [Obsolete("Use generic version of IProgressReport")]
        public static void Report(
            this IProgress<IProgressReport> progress,
            string message,
            double progressValue,
            double progressMaximumValue)
        {
            progress.Report(new ProgressReport(message, progressValue, progressMaximumValue));
        }

        /// <summary>
        ///     Reports a progress update.
        /// </summary>
        /// <param name="progress">
        ///     The object being extended.
        /// </param>
        /// <param name="message">
        ///     The message of the updated progress.
        /// </param>
        /// <param name="progressValue">
        ///     The current progress from [0, <paramref name="progressMaximumValue"/>].
        /// </param>
        /// <param name="progressMaximumValue">
        ///     The maximum progress value.
        /// </param>
        /// <param name="state">
        ///     The state of the long-running operation.
        /// </param>
        [Obsolete("Use generic version of IProgressReport")]
        public static void Report(
            this IProgress<IProgressReport> progress,
            string message,
            double progressValue,
            double progressMaximumValue,
            ProgressState state)
        {
            progress.Report(new ProgressReport(message, progressValue, progressMaximumValue, state));
        }

        /// <summary>
        ///     Reports a progress update.
        /// </summary>
        /// <param name="progress">
        ///     The object being extended.
        /// </param>
        /// <param name="message">
        ///     The message of the updated progress.
        /// </param>
        /// <param name="state">
        ///     The state of the long-running operation.
        /// </param>
        [Obsolete("Use generic version of IProgressReport")]
        public static void Report(
            this IProgress<IProgressReport> progress,
            string message,
            ProgressState state)
        {
            progress.Report(new ProgressReport(message, state));
        }

        /// <summary>
        ///     Reports a change in the progress state to the error state.
        /// </summary>
        /// <param name="progress">
        ///     The object being extended.
        /// </param>
        [Obsolete("Use generic version of IProgressReport")]
        public static void ReportError(this IProgress<IProgressReport> progress)
        {
            progress.Report(new ProgressReport(ProgressState.Error));
        }

        #endregion
    }
}