using CharacterCreator2D;
using CharacterCreator2D.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactIdentifier : MonoBehaviour
{

    private string input;
    public Text Msg;
    private Image sprite;
    public Color myColor;
    public Color myColor2;

    public GameObject guns;
    public GameObject rifle;
    public GameObject hair;
    public GameObject facialHair;
    public GameObject eyebrow;
    public GameObject eyes;
    public GameObject nose;
    public GameObject mouth;
    public GameObject ear;
    public GameObject helmet;
    public GameObject armor;
    public GameObject pants;
    public GameObject skirt;
    public GameObject gloves;
    public GameObject boots;
    public GameObject caps;
    public GameObject mainHand;
    public GameObject offHand;

    public GameObject color1;
    //public GameObject color2;
    //public GameObject color3;

    // Start is called before the first frame update
    void Start()
    {
        guns.SetActive(false);
     //...........................
        hair.SetActive(false);
        facialHair.SetActive(false);
        eyebrow.SetActive(false);
        eyes.SetActive(false);
        nose.SetActive(false);
        mouth.SetActive(false);
        ear.SetActive(false);
        helmet.SetActive(false);
        armor.SetActive(false);
        pants.SetActive(false);
        skirt.SetActive(false);
        gloves.SetActive(false);
        boots.SetActive(false);
        caps.SetActive(false);
        mainHand.SetActive(false);
        offHand.SetActive(false);
        rifle.SetActive(false);

        color1.SetActive(false);
        //color2.SetActive(false);
        //color3.SetActive(false);

        Msg.color = myColor2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s)
    {

        input = s;

        if (s == "guns" || s == "Guns" || s == "GUNS")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(true);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            Msg.color = myColor2;
        }


        else if (s == "hair" || s == "Hair" || s == "HAIR")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(true);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(false);
            //color3.SetActive(false);

            Msg.color = myColor2;

        }

        else if (s == "facial hair" || s == "Facial hair" || s == "FACIAL HAIR")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(true);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(false);
            //color3.SetActive(false);

            Msg.color = myColor2;
        }

        else if (s == "eyebrow" || s == "Eyebrow" || s == "EYEBROW")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(true);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(false);
            //color3.SetActive(false);

            Msg.color = myColor2;
        }

        else if (s == "eyes" || s == "Eyes" || s == "EYES")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(true);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(false);
            //color3.SetActive(false);

            Msg.color = myColor2;
        }

        else if (s == "nose" || s == "Nose" || s == "NOSE")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(true);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;
        }

        else if (s == "mouth" || s == "Mouth" || s == "MOUTH")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(true);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(false);
            //color3.SetActive(false);

            Msg.color = myColor2;

        }

        else if (s == "helmet" || s == "Helmet" || s == "HELMET")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(true);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(false);
            //color3.SetActive(false);

            Msg.color = myColor2;
        }

        else if (s == "ear" || s == "Ear" || s == "EAR")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(true);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;
        }

        else if (s == "armor" || s == "Armor" || s == "ARMOR")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(true);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;
        }

        else if (s == "pants" || s == "Pants" || s == "PANTS")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(true);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;

        }

        else if (s == "skirt" || s == "Skirt" || s == "SKIRT")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(true);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;
        }

        else if (s == "gloves" || s == "Gloves" || s == "GLOVES")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(true);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;
        }

        else if (s == "boots" || s == "Boots" || s == "BOOTS")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(true);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;
        }

        else if (s == "cape" || s == "Cape" || s == "CAPE")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(true);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;
        }

        else if (s == "gun main" || s == "Gun main" || s == "GUN MAIN")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(true);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;
        }

        else if (s == "gun off" || s == "Gun off" || s == "GUN OFF")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(true);
            rifle.SetActive(false);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;
        }

        else if (s == "rifle" || s == "Rifle" || s == "RIFLE")
        {
            Msg.text = s + " Prefabs";
            Debug.Log(s + " Done");

            guns.SetActive(false);

            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(true);

            color1.SetActive(true);
            //color2.SetActive(true);
            //color3.SetActive(true);

            Msg.color = myColor2;

        }


   

        else if (s == "")
        {
            Msg.text = "Please Enter Keyword";
            Debug.Log("Plz Enter");

            guns.SetActive(false);
            //...........................
            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(false);

            Msg.color = myColor2;

        }
        else {

            Msg.text = "No Results";
            Msg.color = myColor;
            Debug.Log("No Results");

            guns.SetActive(false);
            //...........................
            hair.SetActive(false);
            facialHair.SetActive(false);
            eyebrow.SetActive(false);
            eyes.SetActive(false);
            nose.SetActive(false);
            mouth.SetActive(false);
            ear.SetActive(false);
            helmet.SetActive(false);
            armor.SetActive(false);
            pants.SetActive(false);
            skirt.SetActive(false);
            gloves.SetActive(false);
            boots.SetActive(false);
            caps.SetActive(false);
            mainHand.SetActive(false);
            offHand.SetActive(false);
            rifle.SetActive(false);

            color1.SetActive(false);

        }
       

    }
}
