using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace OOP_2_Finale___EFFControleCenter.Services
{
    internal class JsonService
    {
        private static readonly string DataFolder =
            Path.Combine(AppContext.BaseDirectory, "Data");

        /// <summary>
        /// Saves a list of items to a JSON file at the specified file path.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public static async Task SaveToJson<T>(string fileName, List<T> items)
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
        /// <param name="filePath"></param>
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
    }
}
