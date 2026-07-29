using System;
using System.Collections.Generic;
using UnityEngine;
public class TDataDB : SingletonBehavior<TDataDB>
{
    public override void Awake()
    {
        base.Awake();
        Init();
    }
    public void Init()
    {
        dic = new Dictionary<GameDataType, Dictionary<string, TData>>();
        foreach(var tt in Enum.GetValues(typeof(GameDataType)))
        {
            dic[(GameDataType)tt] = new Dictionary<string, TData>();
        }
        GameDataType t = GameDataType.SkillData;
        foreach(var d in skillData)
        {
            dic[t][d.dataId] = d;
        }
    }
    public SkillData GetSkillData(string id)
    {
        return GetData<SkillData>(GameDataType.SkillData,id);
    }
    public T GetData<T>(GameDataType type, string id) where T : TData
    {
        if(!dic.ContainsKey(type)) return default(T);
        if(!dic[type].ContainsKey(id)) return default(T);
        return (T)dic[type][id];
    }
    [SerializeField]private List<SkillData> skillData;
    private Dictionary<GameDataType,Dictionary<string,TData>> dic;

}
public enum GameDataType
{
    SkillData
}