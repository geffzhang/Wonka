﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wonka.MetaData;

namespace WonkaSystem.TestHarness
{
    public class WonkaMetadataVATSource : IMetadataRetrievable
    {
        public WonkaMetadataVATSource()
        { }

        #region Standard Metadata Cache (Minimum Set)

        public List<WonkaRefAttr> GetAttrCache()
        {
            List<WonkaRefAttr> AttrCache = new List<WonkaRefAttr>();

            AttrCache.Add(new WonkaRefAttr() { AttrId = 1, AttrName = "NewSalesTransSeq",    FieldId = 101, GroupId = 1, IsAudited = false, IsNumeric = true, IsKey = true });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 2, AttrName = "NewSaleVATRateDenom", FieldId = 102, GroupId = 1, IsAudited = true, IsNumeric = true, });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 3, AttrName = "NewSaleItemType",     FieldId = 103, GroupId = 1, IsAudited = false, MaxLength = 1024 });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 4, AttrName = "CountryOfSale",       FieldId = 104, GroupId = 1, IsAudited = true, MaxLength = 3 });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 5, AttrName = "NewSalePrice",        FieldId = 105, GroupId = 1, IsAudited = true, IsNumeric = true });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 6, AttrName = "PrevSellTaxAmount",   FieldId = 106, GroupId = 1, IsAudited = true, IsNumeric = true });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 7, AttrName = "NewSellTaxAmount",    FieldId = 107, GroupId = 1, IsAudited = true, IsNumeric = true });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 8, AttrName = "NewVATAmountForHMRC", FieldId = 108, GroupId = 1, IsAudited = true, IsNumeric = true });
            AttrCache.Add(new WonkaRefAttr() { AttrId = 9, AttrName = "NewSaleEAN",          FieldId = 109, GroupId = 1, IsAudited = false, IsNumeric = true, IsKey = false });

            return AttrCache;
        }

        public List<WonkaRefCurrency> GetCurrencyCache()
        {
            List<WonkaRefCurrency> CurrencyCache = new List<WonkaRefCurrency>();

            CurrencyCache.Add(new WonkaRefCurrency() { CurrencyId = 1, CurrencyCd = "USD", USDCost = 1,        USDList = 1 });
            CurrencyCache.Add(new WonkaRefCurrency() { CurrencyId = 2, CurrencyCd = "EUR", USDCost = 1.24f,    USDList = 1.24f });
            CurrencyCache.Add(new WonkaRefCurrency() { CurrencyId = 3, CurrencyCd = "CNY", USDCost = 0.16f,    USDList = 0.16f });
            CurrencyCache.Add(new WonkaRefCurrency() { CurrencyId = 4, CurrencyCd = "BTC", USDCost = 9722.73f, USDList = 9722.73f });
            CurrencyCache.Add(new WonkaRefCurrency() { CurrencyId = 5, CurrencyCd = "USD", USDCost = 811.68f,  USDList = 811.68f });

            return CurrencyCache;
        }

        public List<WonkaRefCadre> GetCadreCache()
        {
            List<WonkaRefCadre> FieldCache = new List<WonkaRefCadre>();

            FieldCache.Add(new WonkaRefCadre() { CadreId = 101, CadreName = "NewSalesTransSeq",    GroupId = 1, AttrIds = new List<int>() { 1 } });
            FieldCache.Add(new WonkaRefCadre() { CadreId = 102, CadreName = "NewSaleVATRateDenom", GroupId = 1, AttrIds = new List<int>() { 2 } });
            FieldCache.Add(new WonkaRefCadre() { CadreId = 103, CadreName = "NewSaleItemType",     GroupId = 1, AttrIds = new List<int>() { 3 } });
            FieldCache.Add(new WonkaRefCadre() { CadreId = 104, CadreName = "CountryOfSale",       GroupId = 1, AttrIds = new List<int>() { 4 } });
            FieldCache.Add(new WonkaRefCadre() { CadreId = 105, CadreName = "NewSalePrice",        GroupId = 1, AttrIds = new List<int>() { 5 } });
            FieldCache.Add(new WonkaRefCadre() { CadreId = 106, CadreName = "PrevSellTaxAmount",   GroupId = 1, AttrIds = new List<int>() { 6 } });
            FieldCache.Add(new WonkaRefCadre() { CadreId = 107, CadreName = "NewSellTaxAmount",    GroupId = 1, AttrIds = new List<int>() { 7 } });
            FieldCache.Add(new WonkaRefCadre() { CadreId = 108, CadreName = "NewVATAmountForHMRC", GroupId = 1, AttrIds = new List<int>() { 8 } });
            FieldCache.Add(new WonkaRefCadre() { CadreId = 109, CadreName = "NewSaleEAN",          GroupId = 1, AttrIds = new List<int>() { 9 } });

            return FieldCache;
        }

        public List<WonkaRefGroup> GetGroupCache()
        {
            List<WonkaRefGroup> GroupCache = new List<WonkaRefGroup>();

            GroupCache.Add(new WonkaRefGroup() { GroupId = 1, GroupName = "Main", Description = "Main data" });

            return GroupCache;
        }

        public List<WonkaRefSource> GetSourceCache()
        {
            List<WonkaRefSource> SourceCache = new List<WonkaRefSource>();

            SourceCache.Add(new WonkaRefSource() { SourceId = 1, SourceName = "TransUnion", Status = "ACT" });
            SourceCache.Add(new WonkaRefSource() { SourceId = 2, SourceName = "Experian", Status = "ACT" });

            return SourceCache;
        }

        public List<WonkaRefSourceCadre> GetSourceCadreCache()
        {
            List<WonkaRefSourceCadre> SourceFieldCache = new List<WonkaRefSourceCadre>();

            SourceFieldCache.Add(new WonkaRefSourceCadre() { SourceCadreId = 1, SourceId = 1, CadreId = 102, SecurityLevel = 3 });
            SourceFieldCache.Add(new WonkaRefSourceCadre() { SourceCadreId = 2, SourceId = 1, CadreId = 2,   SecurityLevel = 1 });
            SourceFieldCache.Add(new WonkaRefSourceCadre() { SourceCadreId = 3, SourceId = 2, CadreId = 102, SecurityLevel = 3 });
            SourceFieldCache.Add(new WonkaRefSourceCadre() { SourceCadreId = 4, SourceId = 2, CadreId = 2,   SecurityLevel = 1 });

            return SourceFieldCache;
        }

        public List<WonkaRefStandard> GetStandardCache()
        {
            List<WonkaRefStandard> StandardCache = new List<WonkaRefStandard>();

            return StandardCache;
        }

        #endregion

        #region Extended Metadata Cache

        public List<WonkaRefAttrCollection> GetAttrCollectionCache()
        {
            List<WonkaRefAttrCollection> AttrCollCache = new List<WonkaRefAttrCollection>();

            return AttrCollCache;
        }

        #endregion
    }
}
