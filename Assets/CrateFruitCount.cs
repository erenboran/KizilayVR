using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CrateFruitCount : MonoBehaviour
{

    public int TotalPoint;
    public int FruitPoint;
    public int MineralPoint;

    [HideInInspector]
    public int Apple = 50;
    public int Banana = 40;
    public int Pinapple = 40;
    public int Lemon = 30;
    public int Pinapple2 = 80;
    public int Watermelon = 60;
    public int Strawberry = 60;
    public int Grape = 60;
    public int Cherry = 80;
    public int Orange = 40;
    public int Mango = 60;
    public int Bonus = 80;
    

        [HideInInspector]
    public int AppleTotal;
    public int PinappleTotal;
    public int LemonTotal;
    public int WatermelonTotal;
    public int StrawberryTotal;
    public int GrapeTotal;
    public int CherryTotal;
    public int OrangeTotal;
    public int MangoTotal;
    public int BonusTotal;

    public int MgTotal;
    public int CaTotal;
    public int NaTotal;
    public int KTotal;
    public int FeTotal;
    public int BiKarTotal;

    public TextMeshProUGUI AppleText;
    public TextMeshProUGUI PinappleText;
    public TextMeshProUGUI LemonText;
    public TextMeshProUGUI WatermelonText;
    public TextMeshProUGUI StrawberryText;
    public TextMeshProUGUI GrapeText;
    public TextMeshProUGUI CherryText;
    public TextMeshProUGUI OrangeText;
    public TextMeshProUGUI MangoText;
    public TextMeshProUGUI BonusText;


    public TextMeshProUGUI MagnezyumText;
    public TextMeshProUGUI CaText;
    public TextMeshProUGUI NaText;
    public TextMeshProUGUI KText;
    public TextMeshProUGUI FeText;
    public TextMeshProUGUI BiKarText;


    public int Mg= 50;
    public int Ca = 30;
    public int Na = 20;
    public int K = 40;
    public int Fe = 40;
    public int BiKar = 50;



    public ParticleSystem GainPoint;


    public AudioSource GainSound;


    public TextMeshProUGUI TotalText;
    public TextMeshProUGUI FruitText;
    public TextMeshProUGUI MaterialText;
    public TextMeshProUGUI MineralPointText;



    private void Update()
    {
        AppleText.text = AppleTotal.ToString();

        PinappleText.text = PinappleTotal.ToString();

        LemonText.text = LemonTotal.ToString();

        WatermelonText.text = WatermelonTotal.ToString();

        StrawberryText.text = StrawberryTotal.ToString();

        GrapeText.text = GrapeTotal.ToString();

        CherryText.text = CherryTotal.ToString();

        OrangeText.text = OrangeTotal.ToString();

        MagnezyumText.text = MgTotal.ToString();

        CaText.text = CaTotal.ToString();

        NaText.text = NaTotal.ToString();

        KText.text = KTotal.ToString();

        FeText.text = FeTotal.ToString();

        BiKarText.text = BiKarTotal.ToString();

        MineralPointText.text = MineralPoint.ToString();

        FruitText.text = FruitPoint.ToString();

        BonusText.text = BonusTotal.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        GainPoint.Play();

        StartCoroutine(Cheer());

        if (other.gameObject.CompareTag("Apple"))
        {
            FruitPoint += Apple;
            TotalPoint += Apple;
            AppleTotal += Apple;
            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();
            FruitText.text = FruitPoint.ToString();
        }

        if (other.gameObject.CompareTag("Bonus"))
        {
            BonusTotal += Bonus;
            other.gameObject.tag = "Untagged";



        }
        if (other.gameObject.CompareTag("Pinapple"))
        {
            FruitPoint += Pinapple;
            TotalPoint += Pinapple;
            PinappleTotal += Pinapple;
            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();
            FruitText.text = FruitPoint.ToString();


        }

        if (other.gameObject.CompareTag("Lemon"))
        {
            FruitPoint += Lemon;
            TotalPoint += Lemon;
            LemonTotal += Lemon;
            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }

        if (other.gameObject.CompareTag("Pinapple2"))
        {
            FruitPoint += Pinapple2;
            TotalPoint += Pinapple2;
            PinappleTotal += Pinapple2;
            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }

        if (other.gameObject.CompareTag("Watermelon"))
        {
            FruitPoint += Watermelon;
            TotalPoint += Watermelon;
            WatermelonTotal += Watermelon;
            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }

        if (other.gameObject.CompareTag("Strawberry"))
        {
            FruitPoint += Strawberry;
            TotalPoint += Strawberry;
            StrawberryTotal += Strawberry;
            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }

        if (other.gameObject.CompareTag("Grape"))
        {
            FruitPoint += Grape;
            TotalPoint += Grape;
            GrapeTotal += Grape;
            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }

        if (other.gameObject.CompareTag("Cherry"))
        {
            FruitPoint += Cherry;
            TotalPoint += Cherry;
            CherryTotal += Cherry;
            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }
        if (other.gameObject.CompareTag("Orange"))
        {
            FruitPoint += Orange;
            TotalPoint += Orange;
            OrangeTotal += Orange;

            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }
        if (other.gameObject.CompareTag("Mango"))
        {
            FruitPoint += Mango;
            TotalPoint += Mango;
            MangoTotal += Mango;

            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }
        if (other.gameObject.CompareTag("Magnezyum"))
        {
            TotalPoint += Mg;
            MgTotal += Mg;
            MineralPoint += Mg;

            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }
        if (other.gameObject.CompareTag("Ca"))
        {
            TotalPoint += Ca;
            CaTotal += Ca;
            MineralPoint += Ca;

            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }
        if (other.gameObject.CompareTag("Na"))
        {
            TotalPoint += Na;
            NaTotal += Na;
            MineralPoint += Na;

            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }

        if (other.gameObject.CompareTag("K"))
        {
            TotalPoint += K;
            KTotal += K;
            MineralPoint += K;

            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }
        if (other.gameObject.CompareTag("Fe"))
        {
            TotalPoint += Fe;
            FeTotal += Fe;
            MineralPoint += Fe;

            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }
        if (other.gameObject.CompareTag("BiKar"))
        {
            TotalPoint += BiKar;
            BiKarTotal += BiKar;
            MineralPoint += BiKar;

            other.gameObject.tag = "Untagged";
            TotalText.text = TotalPoint.ToString();

            FruitText.text = FruitPoint.ToString();

        }


        if (other.gameObject.CompareTag("Mineral"))
        {
            int randomNumber = Random.Range(20, 80);

            MineralPoint += randomNumber;

            TotalPoint += randomNumber;

            other.gameObject.tag = "Untagged";

            TotalText.text = TotalPoint.ToString();

            MaterialText.text = MineralPoint.ToString();

            Debug.Log(randomNumber);
        }


    }

    IEnumerator Cheer()
    {
        GainSound.Play();
        yield return new WaitForSeconds(2f);

    }

}
