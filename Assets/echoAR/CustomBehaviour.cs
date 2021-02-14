/**************************************************************************
* Copyright (C) echoAR, Inc. 2018-2020.                                   *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echoar.xyz/terms, or another agreement                      *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    public GameObject mlkWall = GameObject.Find("MLK_Wall");
    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    // Use this for initialization
    void Start()
    {
        // Add RemoteTransformations script to object and set its entry
        this.gameObject.AddComponent<RemoteTransformations>().entry = entry;

        // Qurey additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;

            if(this.gameObject.name == "MLK")
            {
                //Place MLK photo into wall
                this.gameObject.transform.position = new Vector3(52, 1, 40);
                this.gameObject.transform.localScale = new Vector3(2,2,2);
                this.gameObject.transform.rotation = Quaternion.Euler(90,270,0);

            }

            if (this.gameObject.name == "AG")
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "MLK")
        {
            //Place MLK photo into wall
            this.gameObject.transform.position = new Vector3(52, 1, 40);
            this.gameObject.transform.localScale = new Vector3(2, 2, 2);
            this.gameObject.transform.rotation = Quaternion.Euler(90, 270, 0);

        }
    }
}