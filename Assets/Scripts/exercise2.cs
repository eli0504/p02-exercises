using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour
{
    public int year = 2003; 

    private void Start()
    {
        if (year == 1935|| year == 1947|| year == 1959 || year == 1971 || year == 1983 || year == 1995 || year == 2007 || year == 2019 || year == 2031)
        {
            Debug.Log($"The year {year} belongs to the pork");
        }else if (year == 1924 || year == 1936 || year == 1948 || year == 1960 || year == 1972 || year == 1984 || year == 1996 || year == 2008 || year == 2020)
        {
            Debug.Log($"The year {year} belongs to the rat");
        }else if (year == 1925 || year == 1937 || year == 1949 || year == 1961 || year == 1973 || year == 1985 || year == 1997 || year == 2009 || year == 2021)
        {
            Debug.Log($"The year {year} belongs to the bull");
        }
        else if (year == 1926 || year == 1938 || year == 1950 || year == 1962 || year == 1974 || year == 1986 || year == 1998 || year == 2010 || year == 2022)
        {
            Debug.Log($"The year {year} belongs to the tiger");
        }
        else if (year == 1927 || year == 1939 || year == 1951 || year == 1963 || year == 1975 || year == 1987 || year == 1999 || year == 2011 || year == 2023)
        {
            Debug.Log($"The year {year} belongs to the rabbit");
        }
        else if (year == 1928 || year == 1940 || year == 1952 || year == 1964 || year == 1976 || year == 1988 || year == 2000 || year == 2012 || year == 2024)
        {
            Debug.Log($"The year {year} belongs to the dragon");
        }
        else if (year == 1929 || year == 1941 || year == 1953 || year == 1965 || year == 1977 || year == 1989 || year == 2001 || year == 2013 || year == 2025)
        {
            Debug.Log($"The year {year} belongs to the snake");
        }
        else if (year == 1930 || year == 1942 || year == 1954 || year == 1966 || year == 1978 || year == 1990 || year == 2002 || year == 2014 || year == 2026)
        {
            Debug.Log($"The year {year} belongs to the horse");
        }
        else if (year == 1931 || year == 1943 || year == 1955 || year == 1967 || year == 1979 || year == 1991 || year == 2003 || year == 2015 || year == 2027)
        {
            Debug.Log($"The year {year} belongs to the goat");
        }
        else if ( year == 1932 || year == 1944 || year == 1956 || year == 1968 || year == 1980 || year == 1992 || year == 2004 || year == 2016 || year == 2028)
        {
            Debug.Log($"The year {year} belongs to the monkey");
        }
        else if (year == 1933 || year == 1945 || year == 1957 || year == 1969 || year == 1981 || year == 1993 || year == 2005 || year == 2017 || year == 2029)

            /*
             Is is about each year of the chinese zodiac and their respective animals
            */
        {
            Debug.Log($"The year {year} belongs to the rooster");
        }
        else
        {
            Debug.Log($"The year {year} belongs to the dog");
        }
    }
}
