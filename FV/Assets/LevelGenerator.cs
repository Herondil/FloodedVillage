using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CaseType
{
    sand,
    water,
    empty,
}

public class LevelGenerator : MonoBehaviour
{
    public CaseType[,] LevelGrid;
    public GameObject  SandPrefab;
    public GameObject  WaterPrefab;
    public GameObject  EmptyPrefab;

    public int test {
        get { return 0; }
        set { }
    }

    private void Start()
    {
        LevelGrid = new CaseType[5, 5];

        //le premier indice est la ligne, le second la colonne

        for (int i = 0; i < 5; i++)
        {
            LevelGrid[0, i] = CaseType.empty;
        }
        for (int i = 0; i < 5; i++)
        {
            LevelGrid[1, i] = CaseType.sand;
        }
        for (int i = 0; i < 5; i++)
        {
            LevelGrid[2, i] = CaseType.sand;
        }
        for (int i = 0; i < 5; i++)
        {
            LevelGrid[3, i] = CaseType.sand;
        }
        for (int i = 0; i < 5; i++)
        {
            LevelGrid[4, i] = CaseType.sand;
        }

        LevelGrid[0, 0] = CaseType.sand;
        LevelGrid[0, 1] = CaseType.water;
        GeneratePrefabs();
    }

    private void GeneratePrefabs()
    {
        //Empty Par défaut
        GameObject newInstance = EmptyPrefab;

        if(LevelGrid[0, 0] == CaseType.sand)
        {
            newInstance = SandPrefab;
        }
        if(LevelGrid[0, 0] == CaseType.water)
        {
            newInstance = WaterPrefab;
        }
        if(LevelGrid[0, 0] == CaseType.empty)
        {
            newInstance = EmptyPrefab;
        }

        GameObject g = Instantiate(newInstance, transform);
        g.transform.localPosition = new Vector2(0, 0);

        //----------------     Deuxième case        ---------------------------

        //on rééutilise la variable newinstance
        if (LevelGrid[0, 1] == CaseType.sand)
        {
            newInstance = SandPrefab;
        }
        if (LevelGrid[0, 1] == CaseType.water)
        {
            newInstance = WaterPrefab;
        }
        if (LevelGrid[0, 1] == CaseType.empty)
        {
            newInstance = EmptyPrefab;
        }

        //on réutilise g
        g = Instantiate(newInstance, transform);
        g.transform.localPosition = new Vector2(1, 0);
    }
}
