using System;
using UnityEngine;
using UnityEngine.UI;

public class OutputScores : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private InputField _inputField;

    private void Start()
    {
        _inputField.onValueChanged.AddListener(Interpret);
    }

    private void Interpret(string value)
    {
        if (Int64.TryParse(value, out var number))
        {
            _text.text = ChangeFormat(number);
        }
    }

    private string ChangeFormat(long number)
    {
        if ((number < 0) || (number > 5999999)) throw new ArgumentOutOfRangeException(nameof(number),
            "insert value betwheen 1 and 5999999");

        if (number < 1) return string.Empty;
        if (number >= 1000000 && number <= 1999999) return "1M";
        if (number >= 100000 && number <= 199999) return "100K";
        if (number >= 10000 && number <= 19999) return "10K";
        if (number >= 9000 && number <= 9999) return "9K";
        if (number >= 8000 && number <= 8999) return "8K";
        if (number >= 7000 && number <= 7999) return "7K";
        if (number >= 6000 && number <= 6999) return "6K";
        if (number >= 5000 && number <= 5999) return "5K";
        if (number >= 4000 && number <= 4999) return "4K";
        if (number >= 3000 && number <= 3999) return "3K";
        if (number >= 2000 && number <= 2999) return "2K";
        if (number >= 1000 && number <= 1999) return "1K";

        throw new ArgumentOutOfRangeException(nameof(number));
    }
}


