using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using OOP_2_Finale___EFFControleCenter.Models;

namespace OOP_2_Finale___EFFControleCenter.Services
{
    internal class JsonService
    {
        private static readonly string DataFolder =
            Path.Combine(AppContext.BaseDirectory, "Data");

        /// <summary>
        /// Overwrites a JSON file with a list of items.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public static async Task OverwriteJson<T>(string fileName, List<T> items)
        {
            Directory.CreateDirectory(DataFolder);

            string filePath = Path.Combine(DataFolder, fileName);

            string json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });

            await File.WriteAllTextAsync(filePath, json);
        }

        /// <summary>
        /// Loads a list of items from a JSON file at the specified file path.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static async Task<List<T>> LoadFromJson<T>(string fileName)
        {
            Directory.CreateDirectory(DataFolder);


            string filePath = Path.Combine(DataFolder, fileName);


            if (!File.Exists(filePath))
            {
                return new List<T>();
            }

            string json = await File.ReadAllTextAsync(filePath);

            List<T>? items = JsonSerializer.Deserialize<List<T>>(json);

            return items ?? new List<T>();
        }

        /// <summary>
        /// Appends a list of items to an existing JSON file. If the file does not exist, it creates a new one.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="itemsToAdd"></param>
        /// <returns></returns>
        public static async Task AppendToJson<T>(string fileName, List<T> itemsToAdd)
        {
            List<T> items = await LoadFromJson<T>(fileName);
            items.AddRange(itemsToAdd);
            await OverwriteJson(fileName, items);
        }

        public static async Task<int> GetNextId<T>(string fileName) where T : Entity
        {
            List<T> items = await LoadFromJson<T>(fileName);
            if (items.Count == 0)
            {
                return 1;
            }
            return items.Max(x => x.Id) + 1;
        }
    }
}
