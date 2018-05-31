﻿using System;
using System.Threading.Tasks;

namespace CommandLine.Verbs
{
    /// <summary>
    /// CommandCommands handler
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Returns type of options class
        /// </summary>
        Type OptionsType { get; }
        /// <summary>
        /// Checks if can handle options class type
        /// </summary>
        /// <param name="options"></param>
        /// <returns>True when verb handler can handle option class type</returns>
        bool CanHandle(object options);
        int Execute(object options);
        Task<int> ExecuteAsync(object options);
    }

    /// <summary>
    /// Generic verb commands handler
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommand<in T> : ICommand where T : class
    {
        int Execute(T options);
        Task<int> ExecuteAsync(T options);
    }
}
