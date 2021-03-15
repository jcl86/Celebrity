﻿namespace Celebrity.Shared
{
    public static class SubcategoryEndpoints
    {
        public const string Base = "api/subcategories";

        public static string GetSubcategories() => Base;
        public static string GetSubcategory(int subcategoryId) => $"{Base}/{subcategoryId}";

        public static string PostCreate => Base;
        public static string PatchUpdate => Base;

        public static string DeleteSubcategory(int subcategoryId) => $"{Base}/{subcategoryId}";
    }
}
