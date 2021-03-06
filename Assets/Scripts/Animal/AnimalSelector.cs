using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Public Enums
public enum Animal
{
    Dog,
    Cat,
    Fish,
    Parrot
}
#endregion

public class AnimalSelector : MonoBehaviour
{
    #region Unity Methods
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            CheckSwitchCase(Animal.Cat);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            CheckSwitchCase(Animal.Dog);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            CheckSwitchCase(Animal.Fish);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            CheckSwitchCase(Animal.Parrot);
        }
    }
    #endregion

    #region Private Methods
    private void CheckSwitchCase(Animal animal)
    {
        switch (animal)
        {
            case Animal.Cat:
                OnCatSelected();
                break;
            case Animal.Dog:
                OnDogSelected();
                break;
            case Animal.Fish:
                OnFishSelected();
                break;
            case Animal.Parrot:
                OnParrotSelected();
                break;
            default:
                Debug.Log("Default");
                break;
        }
    }

    private void OnCatSelected()
    {
        Debug.Log("Cat Selected");
    }

    private void OnDogSelected()
    {
        Debug.Log("Dog Selected");
    }

    private void OnFishSelected()
    {
        Debug.Log("Fish Selected");
    }

    private void OnParrotSelected()
    {
        Debug.Log("Parrot Selected");
    }
    #endregion
}
