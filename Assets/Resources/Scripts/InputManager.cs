using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [Header("SCOREBOARD")]
    [SerializeField] private List<int> SCOREBOARD;
    [Header("Input")]
    [SerializeField] private int maxKeysPressedAtOnce;
    [SerializeField] private float timeToRepairPaneInSeconds;
    [SerializeField] private float zeroToOneValForRandom;
    [SerializeField] private List<KeyCode> keysCurrentlyPressed; // can limit to be like 5...
    [Header("Sliming")]
    [SerializeField] private float currentSlimingInterval;
    [SerializeField] private Glass[] glassPieces = new Glass[44];
    [SerializeField] private float currentSlimingIntervalTimeElapsed;
    [Header("Oxygen")]
    [SerializeField] SpriteRenderer oxygenBarSpriteRenderer;
    [SerializeField] Sprite[] oxygenBarSprites = new Sprite[41];
    [SerializeField] public int oxygenCount;
    [SerializeField] private float oxygenTickInterval;
    [SerializeField] private float oxygenTickIntervalTimeElapsed;
    [SerializeField] private Sprite whitescreen;
    [SerializeField] private Sprite spacetostartscreen;
    [SerializeField] private Sprite[] startingScreens;
    [SerializeField] private int oxygenDefaultGain;
    [Header("LevelSystem")]
    [SerializeField] private float gameTimeElapsed;
    [SerializeField] public int currentLevel;
    [SerializeField] private float level1StartTime;
    [SerializeField] private float level2StartTime;
    [SerializeField] private float level3StartTime;
    [SerializeField] private float level4StartTime;
    [SerializeField] private float level5StartTime;
    [SerializeField] private float level6StartTime;
    [SerializeField] private int level1OxygenDefaultGain;
    [SerializeField] private int level2OxygenDefaultGain;
    [SerializeField] private int level3OxygenDefaultGain;
    [SerializeField] private int level4OxygenDefaultGain;
    [SerializeField] private int level5OxygenDefaultGain;
    [SerializeField] private int level6OxygenDefaultGain;
    [SerializeField] private GameObject Alien1;
    [SerializeField] private GameObject Alien2;
    [SerializeField] private GameObject slimeKing;
    [SerializeField] private float phase6LapseTime;
    private float phase6LapseTimeTimeElapsed; // real smart name right there coop
    private float phase6LapseTimeTimeElapsedOtherElapsed; // real smart name right there coop
    [Header("Menu")]
    [SerializeField] private bool firstRun;
    [SerializeField] public bool gameActive;
    [SerializeField] public bool incutscenes;
    public delegate void OnResetGameEvent();
    public static event OnResetGameEvent ResetGameEvent;
    private bool startGameCooldown;
    [Header("Score")]
    [SerializeField] private float scoreTickInterval;
    [SerializeField] private float scoreTickIntervalTimeElapsed;
    [SerializeField] private int score;
    [SerializeField] private int highscrore;
    [SerializeField] private TextMeshProUGUI tmp;
    [SerializeField] private TextMeshProUGUI hghscoreTMP;

    private void Start()
    {
        tmp.text = "0";
        score = 0;
        gameActive = false;
        firstRun = true;
        hghscoreTMP.text = "";
        startGameCooldown = false;
        highscrore = 0;
        incutscenes = true;
        oxygenBarSpriteRenderer.sprite = startingScreens[1]; // space to styart
    }
    private void Update()
    {
        if (oxygenCount > 0)
        {
            #region KEY INPUT PRESSES
            // KEY INPUT PRESSES
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                TryPressKey(KeyCode.Alpha1);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                TryPressKey(KeyCode.Alpha2);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                TryPressKey(KeyCode.Alpha3);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                TryPressKey(KeyCode.Alpha4);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                TryPressKey(KeyCode.Alpha5);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                TryPressKey(KeyCode.Alpha6);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                TryPressKey(KeyCode.Alpha7);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                TryPressKey(KeyCode.Alpha8);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                TryPressKey(KeyCode.Alpha9);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                TryPressKey(KeyCode.Alpha0);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                TryPressKey(KeyCode.Minus);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                TryPressKey(KeyCode.Equals);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                TryPressKey(KeyCode.Q);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                TryPressKey(KeyCode.W);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                TryPressKey(KeyCode.E);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                TryPressKey(KeyCode.R);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                TryPressKey(KeyCode.T);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                TryPressKey(KeyCode.Y);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                TryPressKey(KeyCode.U);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                TryPressKey(KeyCode.I);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                TryPressKey(KeyCode.O);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                TryPressKey(KeyCode.P);
            }
            if (Input.GetKeyDown(KeyCode.LeftBracket))
            {
                TryPressKey(KeyCode.LeftBracket);
            }
            if (Input.GetKeyDown(KeyCode.RightBracket))
            {
                TryPressKey(KeyCode.RightBracket);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                TryPressKey(KeyCode.A);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                TryPressKey(KeyCode.S);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                TryPressKey(KeyCode.D);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                TryPressKey(KeyCode.F);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                TryPressKey(KeyCode.G);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                TryPressKey(KeyCode.H);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                TryPressKey(KeyCode.J);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                TryPressKey(KeyCode.K);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                TryPressKey(KeyCode.L);
            }
            if (Input.GetKeyDown(KeyCode.Semicolon))
            {
                TryPressKey(KeyCode.Semicolon);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                TryPressKey(KeyCode.BackQuote);
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                TryPressKey(KeyCode.Z);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                TryPressKey(KeyCode.X);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                TryPressKey(KeyCode.C);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                TryPressKey(KeyCode.V);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                TryPressKey(KeyCode.B);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                TryPressKey(KeyCode.N);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                TryPressKey(KeyCode.M);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                TryPressKey(KeyCode.Comma);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                TryPressKey(KeyCode.Period);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                TryPressKey(KeyCode.Slash);
            }
            #endregion
            OxygenTick();
            LevelSystem();
            UpdateScore();
        }
        else
        {
            foreach (var item in glassPieces)
            {
                item.isIntact = false;
            }
        }
        if (gameActive == false && !startGameCooldown)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                startGameCooldown = true;
                if (firstRun)
                {
                    firstRun = false;
                    ResetGameForFirstRun();
                    return;
                }
                ResetGame();
            }
        }
    }

    // --------------------------------------------------------------------------------------------
    // SCORE
    // --------------------------------------------------------------------------------------------

    private void UpdateScore()
    {
        scoreTickIntervalTimeElapsed += Time.deltaTime;
        if (scoreTickIntervalTimeElapsed > scoreTickInterval)
        {
            scoreTickIntervalTimeElapsed = 0;
            int scoreAdd = (45 - GetSlimeActive()) * (int)Mathf.Round(Mathf.Pow(currentLevel, 1.5f)) * 10;
            if (scoreAdd == 0) score += 10;
            else score += scoreAdd;
            tmp.text = score.ToString();
        }
    }

    // --------------------------------------------------------------------------------------------
    // MENU
    // --------------------------------------------------------------------------------------------

    private void ResetGame()
    {
        Debug.Log("START NEW GAME");
        ResetGameEvent.Invoke();
        gameActive = true;
        oxygenCount = 40;
        currentLevel = 0;
        score = 0;
        phase6LapseTimeTimeElapsedOtherElapsed = 0;
        phase6LapseTimeTimeElapsed = 0;
        gameTimeElapsed = 0;
        tmp.text = "";
        foreach (int score in SCOREBOARD)
        {
            if (score > highscrore)
            {
                highscrore = score;
            }
        }
        hghscoreTMP.text = "Highscore: " + highscrore.ToString();
        StartCoroutine(StartAlienCoroutine());
    }

    private IEnumerator StartAlienCoroutine()
    {
        yield return new WaitForSeconds(2f);
        startGameCooldown = false;
        Instantiate(Alien1, new Vector3(0, 3.5f, 0), Quaternion.identity);
    }

    private void ResetGameForFirstRun()
    {
        StartCoroutine(FirstRunCoroutine());
    }
    private IEnumerator FirstRunCoroutine()
    {
        tmp.text = "";
        yield return new WaitForSeconds(.25f);
        oxygenBarSpriteRenderer.sprite = startingScreens[2]; // hello
        yield return new WaitForSeconds(4f);
        oxygenBarSpriteRenderer.sprite = startingScreens[3]; // dreamed of space
        yield return new WaitForSeconds(4f);
        oxygenBarSpriteRenderer.sprite = startingScreens[4]; // dream a reality
        yield return new WaitForSeconds(4f);
        oxygenBarSpriteRenderer.sprite = startingScreens[5]; // elecaator
        yield return new WaitForSeconds(2.5f);
        oxygenBarSpriteRenderer.sprite = startingScreens[6]; // elevatORasphyxiate
        yield return new WaitForSeconds(4.5f);
        oxygenBarSpriteRenderer.sprite = startingScreens[7]; // wiper
        yield return new WaitForSeconds(3f);
        oxygenBarSpriteRenderer.sprite = startingScreens[8]; // keys
        yield return new WaitForSeconds(3.5f);
        oxygenBarSpriteRenderer.sprite = startingScreens[9]; // key demostrations
        yield return new WaitForSeconds(4.5f);
        oxygenBarSpriteRenderer.sprite = startingScreens[10]; // key demostrations 2
        yield return new WaitForSeconds(4.5f);
        oxygenBarSpriteRenderer.sprite = startingScreens[11]; // goo == death
        yield return new WaitForSeconds(4.5f);
        oxygenBarSpriteRenderer.sprite = startingScreens[12]; // no o2 = death
        yield return new WaitForSeconds(4f);
        oxygenBarSpriteRenderer.sprite = startingScreens[6]; // elevatORasphyxiate
        yield return new WaitForSeconds(1f);
        incutscenes = false;

        Debug.Log("START NEW GAME");
        ResetGameEvent.Invoke();
        gameActive = true;
        oxygenCount = 40;
        score = 0;
        phase6LapseTimeTimeElapsedOtherElapsed = 0;
        phase6LapseTimeTimeElapsed = 0;
        currentLevel = 0;
        startGameCooldown = false;
        gameTimeElapsed = 0;
        tmp.text = "0";
        StartCoroutine(StartAlienCoroutine());
    }

    // --------------------------------------------------------------------------------------------
    // LEVELS
    // --------------------------------------------------------------------------------------------
    private void LevelSystem()
    {
        gameTimeElapsed += Time.deltaTime;
        if (currentLevel < 1 && gameTimeElapsed > level1StartTime)
        {
            if (currentLevel != 0) return;
            Debug.Log("LEVEL 1");
            currentLevel = 1;
            oxygenDefaultGain = level1OxygenDefaultGain;
            Instantiate(Alien1, new Vector3(0, 3.5f, 0), Quaternion.identity);
        }
        if (currentLevel < 2 && gameTimeElapsed > level2StartTime)
        {
            if (currentLevel != 1) return;
            Debug.Log("LEVEL 2");
            currentLevel = 2;
            oxygenDefaultGain = level2OxygenDefaultGain;
            Instantiate(Alien2, new Vector3(0, 3.5f, 0), Quaternion.identity);
        }
        if (currentLevel < 3 && gameTimeElapsed > level3StartTime)
        {
            if (currentLevel != 2) return;
            Debug.Log("LEVEL 3");
            currentLevel = 3;
            oxygenDefaultGain = level3OxygenDefaultGain;
            Instantiate(Alien1, new Vector3(0, 3.5f, 0), Quaternion.identity);
            Instantiate(Alien1, new Vector3(0, 3.5f, 0), Quaternion.identity);
        }
        if (currentLevel < 4 && gameTimeElapsed > level4StartTime)
        {
            if (currentLevel != 3) return;
            Debug.Log("LEVEL 4");
            currentLevel = 4;
            oxygenDefaultGain = level4OxygenDefaultGain;
            Instantiate(Alien2, new Vector3(0, 3.5f, 0), Quaternion.identity);
        }
        if (currentLevel < 5 && gameTimeElapsed > level4StartTime)
        {
            if (currentLevel != 4) return;
            Debug.Log("LEVEL 5");
            currentLevel = 5;
            oxygenDefaultGain = level5OxygenDefaultGain;
            Instantiate(slimeKing, new Vector3(0, 3.5f, 0), Quaternion.identity);
        }
        if (currentLevel < 6 && gameTimeElapsed > level4StartTime)
        {
            if (currentLevel != 5) return;
            Debug.Log("LEVEL 6");
            currentLevel = 6;
            oxygenDefaultGain = level6OxygenDefaultGain;
            maxKeysPressedAtOnce += 2;
            timeToRepairPaneInSeconds *= .8f;
            Instantiate(Alien2, new Vector3(0, 3.5f, 0), Quaternion.identity);
        }
        if (currentLevel == 6)
        {
            phase6LapseTimeTimeElapsed += Time.deltaTime;
            phase6LapseTimeTimeElapsedOtherElapsed += Time.deltaTime;
            if (phase6LapseTime < phase6LapseTimeTimeElapsed)
            {
                phase6LapseTimeTimeElapsed = 0;
                Instantiate(Alien1, new Vector3(0, 3.5f, 0), Quaternion.identity);
            }
            if (phase6LapseTime < phase6LapseTimeTimeElapsedOtherElapsed)
            {
                phase6LapseTimeTimeElapsedOtherElapsed = 0;
                Instantiate(Alien1, new Vector3(0, 3.5f, 0), Quaternion.identity);
                Instantiate(Alien2, new Vector3(0, 3.5f, 0), Quaternion.identity);
            }
        }

    }

    // --------------------------------------------------------------------------------------------
    // OXYGEN
    // --------------------------------------------------------------------------------------------
    private void OxygenTick()
    {
        oxygenTickIntervalTimeElapsed += Time.deltaTime;
        if (oxygenTickIntervalTimeElapsed > oxygenTickInterval)
        {
            oxygenTickIntervalTimeElapsed = 0;
            oxygenCount += oxygenDefaultGain - GetSlimeActive();
            if (oxygenCount > 40) oxygenCount = 40;
            else if (oxygenCount < 0) oxygenCount = 0;
            oxygenBarSpriteRenderer.sprite = oxygenBarSprites[40 - oxygenCount];
        }
        if (oxygenCount == 0)
        {
            SCOREBOARD.Add(score);
            StartCoroutine(WhiteScreenCoroutine());
        }
    }

    private IEnumerator WhiteScreenCoroutine()
    {
        yield return new WaitForSeconds(3);
        oxygenBarSpriteRenderer.sprite = startingScreens[0]; // blank
        yield return new WaitForSeconds(1);
        oxygenBarSpriteRenderer.sprite = startingScreens[1]; // space to start
        gameActive = false;
    }

    // --------------------------------------------------------------------------------------------
    // SLIME
    // --------------------------------------------------------------------------------------------
    public void RandomlySlimeGlass()
    {
        if (GetSlimeActive() == 44) return;
        int random;
        do
        {
            random = (int)Random.Range(0f, 43f);
        } while (glassPieces[random].isIntact);
        SlimeGlass(random);
    }

    private void SlimeGlass(int index)
    {
        glassPieces[index].isIntact = true;
        glassPieces[index].spriteRenderer.color = GetRandomColorOnWheel();
    }

    public Color GetRandomColorOnWheel()
    {
        float randomHue = Random.Range(0f, 1f);
        return Color.HSVToRGB(randomHue, 1, 1);
    }

    private int GetSlimeActive() // used for difficulty and wonder depletion!
    {
        int ret = 0;
        foreach (var piece in glassPieces)
        {
            if (piece.isIntact) ret++;
        }
        return ret;
    }

    public void SlimeBasedOnPosition(Vector3 pos)
    {
        float slimeRet = 0;
        float X = pos.x;
        float Y = pos.y;
        //  -------------
        //  |     13
        //  | 6
        //  |
        int row;
        if (Y > -1) // top half
        {
            if (Y > 1.5) // ROW 1
            {
                row = 1;
            }
            else // ROW 2
            {
                row = 2;
            }
        }
        else // bottom
        {
            if (Y > -2.5) // ROW 3
            {
                row = 3;
            }
            else // ROW 4
            {
                row = 4;
            }
        }
        if (row > 4 || row < 0)
        {
            return;
        }
        else if (row < 3) // 12 per row
        {
            X += 6.5f;
            // X *= 12 / 13;
            X *= 12;
            X /= 13;
            if (row == 1)
            {
                slimeRet = X;
            }
            else if (row == 2)
            {
                slimeRet = X + 12;
            }
        }
        else if (row == 3) // 11 per row
        {
            X += 6.5f;
            // X *= 11 / 13;
            X *= 11;
            X /= 13;
            slimeRet = X + 23;
        }
        else if (row == 4) // 10 per row
        {
            X += 6.5f;
            // X *= 10 / 13;
            X *= 10;
            X /= 13;
            slimeRet = X + 33;
        }
        SlimeGlass(Mathf.RoundToInt(slimeRet));
    }

    // --------------------------------------------------------------------------------------------
    // INPUT
    // --------------------------------------------------------------------------------------------

    private void TryPressKey(KeyCode key)
    {
        if (keysCurrentlyPressed.Contains(key)) return;
        else if (keysCurrentlyPressed.Count > maxKeysPressedAtOnce) return;
        else
        {
            keysCurrentlyPressed.Add(key);
        }
        StartCoroutine(FixGlassIfKeyHeldForLongEnoughCoroutine(key));
    }

    private IEnumerator FixGlassIfKeyHeldForLongEnoughCoroutine(KeyCode keycode)
    {
        bool brokedAndFailed = false;
        float timeElapsed = 0;
        while (timeElapsed < timeToRepairPaneInSeconds)
        {
            // TODO ARM ANIMATION COMES IN HERE
            if (Input.GetKeyUp(keycode)) { brokedAndFailed = true; break; }
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        if (brokedAndFailed)
        {
        }
        else
        {
            oxygenCount++;
            #region MASSIVE REPAIR CHAIN
            float randomValue = Random.value;

            if (keycode == KeyCode.Alpha1)
            {
                glassPieces[0].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[1].isIntact = false;
                    glassPieces[12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Alpha2)
            {
                glassPieces[1].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[0].isIntact = false;
                    glassPieces[2].isIntact = false;
                    glassPieces[13].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Alpha3)
            {
                glassPieces[2].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[1].isIntact = false;
                    glassPieces[3].isIntact = false;
                    glassPieces[14].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Alpha4)
            {
                glassPieces[3].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[2].isIntact = false;
                    glassPieces[4].isIntact = false;
                    glassPieces[15].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Alpha5)
            {
                glassPieces[4].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[3].isIntact = false;
                    glassPieces[5].isIntact = false;
                    glassPieces[16].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Alpha6)
            {
                glassPieces[5].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[4].isIntact = false;
                    glassPieces[6].isIntact = false;
                    glassPieces[17].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Alpha7)
            {
                glassPieces[6].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[5].isIntact = false;
                    glassPieces[7].isIntact = false;
                    glassPieces[18].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Alpha8)
            {
                glassPieces[7].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[6].isIntact = false;
                    glassPieces[8].isIntact = false;
                    glassPieces[19].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Alpha9)
            {
                glassPieces[8].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[7].isIntact = false;
                    glassPieces[9].isIntact = false;
                    glassPieces[20].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Alpha0)
            {
                glassPieces[9].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[8].isIntact = false;
                    glassPieces[10].isIntact = false;
                    glassPieces[21].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Minus)
            {
                glassPieces[10].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[9].isIntact = false;
                    glassPieces[11].isIntact = false;
                    glassPieces[22].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Equals)
            {
                glassPieces[11].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[10].isIntact = false;
                    glassPieces[22].isIntact = false;
                }
            }
            // ROW 2 ------------------------------------
            // ROW 2 ------------------------------------
            // ROW 2 ------------------------------------
            if (keycode == KeyCode.Q)
            {
                glassPieces[12 + 0].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 1].isIntact = false;
                    glassPieces[12 + 12].isIntact = false;
                    glassPieces[12 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.W)
            {
                glassPieces[12 + 1].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 0].isIntact = false;
                    glassPieces[12 + 2].isIntact = false;
                    glassPieces[12 + 13].isIntact = false;
                    glassPieces[13 - 12].isIntact = false;
                }

            }
            else if (keycode == KeyCode.E)
            {
                glassPieces[12 + 2].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 1].isIntact = false;
                    glassPieces[12 + 3].isIntact = false;
                    glassPieces[12 + 14].isIntact = false;
                    glassPieces[14 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.R)
            {
                glassPieces[12 + 3].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 2].isIntact = false;
                    glassPieces[12 + 4].isIntact = false;
                    glassPieces[12 + 15].isIntact = false;
                    glassPieces[15 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.T)
            {
                glassPieces[12 + 4].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 3].isIntact = false;
                    glassPieces[12 + 5].isIntact = false;
                    glassPieces[12 + 16].isIntact = false;
                    glassPieces[16 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Y)
            {
                glassPieces[12 + 5].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 4].isIntact = false;
                    glassPieces[12 + 6].isIntact = false;
                    glassPieces[12 + 17].isIntact = false;
                    glassPieces[17 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.U)
            {
                glassPieces[12 + 6].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 5].isIntact = false;
                    glassPieces[12 + 7].isIntact = false;
                    glassPieces[12 + 18].isIntact = false;
                    glassPieces[18 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.I)
            {
                glassPieces[12 + 7].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 6].isIntact = false;
                    glassPieces[12 + 8].isIntact = false;
                    glassPieces[12 + 19].isIntact = false;
                    glassPieces[19 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.O)
            {
                glassPieces[12 + 8].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 7].isIntact = false;
                    glassPieces[12 + 9].isIntact = false;
                    glassPieces[12 + 20].isIntact = false;
                    glassPieces[20 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.P)
            {
                glassPieces[12 + 9].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 8].isIntact = false;
                    glassPieces[12 + 10].isIntact = false;
                    glassPieces[12 + 21].isIntact = false;
                    glassPieces[21 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.LeftBracket)
            {
                glassPieces[12 + 10].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 9].isIntact = false;
                    glassPieces[12 + 11].isIntact = false;
                    glassPieces[12 + 22].isIntact = false;
                    glassPieces[22 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.RightBracket)
            {
                glassPieces[12 + 11].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 10].isIntact = false;
                    glassPieces[12 + 23].isIntact = false;
                    glassPieces[22 - 12].isIntact = false;
                }
            }
            // ROW 3 ------------------------------------
            // ROW 3 ------------------------------------
            // ROW 3 ------------------------------------
            if (keycode == KeyCode.A)
            {
                glassPieces[12 + 12 + 0].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 1].isIntact = false;
                    glassPieces[12 + 12 + 8].isIntact = false;
                    glassPieces[12 + 12 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.S)
            {
                glassPieces[12 + 12 + 1].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 0].isIntact = false;
                    glassPieces[12 + 12 + 2].isIntact = false;
                    glassPieces[12 + 12 + 9].isIntact = false;
                    glassPieces[12 + 13 - 12].isIntact = false;
                }

            }
            else if (keycode == KeyCode.D)
            {
                glassPieces[12 + 12 + 2].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 1].isIntact = false;
                    glassPieces[12 + 12 + 3].isIntact = false;
                    glassPieces[12 + 12 + 10].isIntact = false;
                    glassPieces[12 + 14 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.F)
            {
                glassPieces[12 + 12 + 3].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 2].isIntact = false;
                    glassPieces[12 + 12 + 4].isIntact = false;
                    glassPieces[12 + 12 + 11].isIntact = false;
                    glassPieces[12 + 15 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.G)
            {
                glassPieces[12 + 12 + 4].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 3].isIntact = false;
                    glassPieces[12 + 12 + 5].isIntact = false;
                    glassPieces[12 + 12 + 12].isIntact = false;
                    glassPieces[12 + 16 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.H)
            {
                glassPieces[12 + 12 + 5].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 4].isIntact = false;
                    glassPieces[12 + 12 + 6].isIntact = false;
                    glassPieces[12 + 12 + 14].isIntact = false;
                    glassPieces[12 + 17 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.J)
            {
                glassPieces[12 + 12 + 6].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 5].isIntact = false;
                    glassPieces[12 + 12 + 7].isIntact = false;
                    glassPieces[12 + 12 + 15].isIntact = false;
                    glassPieces[12 + 18 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.K)
            {
                glassPieces[12 + 12 + 7].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 6].isIntact = false;
                    glassPieces[12 + 12 + 8].isIntact = false;
                    glassPieces[12 + 12 + 16].isIntact = false;
                    glassPieces[12 + 19 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.L)
            {
                glassPieces[12 + 12 + 8].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 7].isIntact = false;
                    glassPieces[12 + 12 + 9].isIntact = false;
                    glassPieces[12 + 12 + 17].isIntact = false;
                    glassPieces[12 + 20 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Semicolon)
            {
                glassPieces[12 + 12 + 9].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 8].isIntact = false;
                    glassPieces[12 + 12 + 10].isIntact = false;
                    glassPieces[12 + 12 + 18].isIntact = false;
                    glassPieces[12 + 21 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.BackQuote)
            {
                glassPieces[12 + 12 + 10].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[12 + 12 + 9].isIntact = false;
                    glassPieces[12 + 12 + 19].isIntact = false;
                    glassPieces[12 + 22 - 12].isIntact = false;
                }
            }
            // ROW 4 ------------------------------------
            // ROW 4 ------------------------------------
            // ROW 4 ------------------------------------
            if (keycode == KeyCode.Z)
            {
                glassPieces[22 + 12 + 0].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[22 + 12 + 1].isIntact = false;
                    glassPieces[22 + 12 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.X)
            {
                glassPieces[22 + 12 + 1].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[22 + 12 + 0].isIntact = false;
                    glassPieces[22 + 12 + 2].isIntact = false;
                    glassPieces[22 + 13 - 12].isIntact = false;
                }

            }
            else if (keycode == KeyCode.C)
            {
                glassPieces[22 + 12 + 2].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[22 + 12 + 1].isIntact = false;
                    glassPieces[22 + 12 + 3].isIntact = false;
                    glassPieces[22 + 14 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.V)
            {
                glassPieces[22 + 12 + 3].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[22 + 12 + 2].isIntact = false;
                    glassPieces[22 + 12 + 4].isIntact = false;
                    glassPieces[22 + 15 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.B)
            {
                glassPieces[22 + 12 + 4].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[22 + 12 + 3].isIntact = false;
                    glassPieces[22 + 12 + 5].isIntact = false;
                    glassPieces[22 + 16 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.N)
            {
                glassPieces[22 + 12 + 5].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[22 + 12 + 4].isIntact = false;
                    glassPieces[22 + 12 + 6].isIntact = false;
                    glassPieces[22 + 17 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.M)
            {
                glassPieces[22 + 12 + 6].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[22 + 12 + 5].isIntact = false;
                    glassPieces[22 + 12 + 7].isIntact = false;
                    glassPieces[22 + 18 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Comma)
            {
                glassPieces[22 + 12 + 7].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[22 + 12 + 6].isIntact = false;
                    glassPieces[22 + 12 + 8].isIntact = false;
                    glassPieces[22 + 19 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Period)
            {
                glassPieces[22 + 12 + 8].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[22 + 12 + 7].isIntact = false;
                    glassPieces[22 + 12 + 9].isIntact = false;
                    glassPieces[22 + 20 - 12].isIntact = false;
                }
            }
            else if (keycode == KeyCode.Slash)
            {
                glassPieces[22 + 12 + 9].isIntact = false;
                if (randomValue < zeroToOneValForRandom)
                {
                    glassPieces[22 + 12 + 8].isIntact = false;
                    glassPieces[22 + 21 - 12].isIntact = false;
                }
            }
            #endregion
        }
        keysCurrentlyPressed.Remove(keycode);
    }
}