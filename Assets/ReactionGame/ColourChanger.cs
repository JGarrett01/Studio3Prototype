using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColourChanger : MonoBehaviour {

    public Color colourCom;
    private Image image;

    [SerializeField]
    private Color m_goodColor = Color.green;

    [SerializeField]
    private Color m_badColor = Color.red;

    [SerializeField]
    private Color m_neutralColor = Color.white;

    [SerializeField]
    private Vector2 m_flashDelaty;

    private float m_currentTime = 0f;
    private float m_targetTime;

    private bool m_flashing = false;

    void Awake()
    {
        image = GetComponent<Image>();
    }

	void Update ()
    {
        if (!m_flashing)
        {
            m_currentTime += Time.deltaTime;

            if (m_currentTime >= m_targetTime)
            {

                if (Random.Range(0, 100) >= 70)
                {
                    StartCoroutine(FlashColor(m_badColor));
                }
                else
                {
                    StartCoroutine(FlashColor(m_goodColor));
                }
              
                m_targetTime = Random.Range(m_flashDelaty.x, m_flashDelaty.y);
            }
        }
    }

    void OnMouseDown()
    {
        image.color = colourCom;
    }

    IEnumerator FlashColor(Color a_color)
    {
        m_flashing = true;

        image.color = a_color;

        float time = 0f;

        while (time < 1f)
        {
            image.color = Color.Lerp(a_color, m_neutralColor, time);
            time += Time.deltaTime;

            yield return null;
        }

        image.color = m_neutralColor;

        m_flashing = false;
    }
}
