using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CollectorController : MonoBehaviour
{
    private IDictionary<CollectibleType, float> _collectibles;

    private void Awake()
    {
        _collectibles = new Dictionary<CollectibleType, float>();
    }

    public void Increase(CollectibleType collecttibleType, float value) 
    {
        if (_collectibles.ContainsKey(collecttibleType))
        {
            _collectibles[collecttibleType] += Mathf.Abs(value);

        }
        else
        {
            _collectibles.Add(collecttibleType, Mathf.Abs(value));
        }
        CollectibleManager.Instance.UpdateTextbox(collecttibleType, _collectibles[collecttibleType]);
    }

    public void Decrease(CollectibleType collecttibleType, float value)
    {
        if (!_collectibles.ContainsKey(collecttibleType))
        {
            
            return;
        }
        _collectibles[collecttibleType]-= Mathf.Abs(value);
        if (_collectibles[collecttibleType]<=0) 
        {
            _collectibles.Remove(collecttibleType);
            CollectibleManager.Instance.UpdateTextbox(collecttibleType, 0);
            return;
        }

        CollectibleManager.Instance.UpdateTextbox(collecttibleType, _collectibles[collecttibleType]);

    }

}
