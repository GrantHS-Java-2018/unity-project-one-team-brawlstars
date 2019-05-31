using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.CardScripts;
public class Deck : MonoBehaviour
{
    public int NCARDS = 16;

    private Card[] deckOfCards;         // Contains all 16 cards
    private int currentCard;            // deal THIS card in deck

    public void DeckOfCards( )
    {
         /* =================================================================
            First: create the array
            ================================================================= */
        deckOfCards = new Card[ NCARDS ];
        deckOfCards[0] = new Card(1, 1);
        // We must crate the array first !
        deckOfCards[0] = ();
        



        currentCard = 0;         // Fresh deck of card...
    }

    /* ------------------------------------------------
      shuffle(n): shuffle the deck using n exchanges
      ------------------------------------------------ */

    public void shuffle()
    {
        int n = 400;
        int i, j, k;

        for ( k = 0; k < n; k++ )
        {
            i = (int) ( NCARDS * Math.random() );  // Pick 2 random cards
            j = (int) ( NCARDS * Math.random() );  // in the deck

          /* ---------------------------------
             Swap these randomly picked cards
             --------------------------------- */
            Card tmp = deckOfCards[i];
            deckOfCards[i] = deckOfCards[j];
            deckOfCards[j] = tmp;
        }

        currentCard = 0;   // Reset current card to deal from top of deck
    }

    /* ---------------------------------------------------------
       deal(): deal the next card in the deck
      i.e. deal deckOfCards[currentCard] out
   --------------------------------------------------------- */

    public Card deal()
    {
        if ( currentCard < NCARDS )
        {
            return ( deckOfCards[ currentCard++ ] );
        }
        else
        {
            System.out.println("Out of cards error");
            return ( null );  // Error;
        }
    }

    public String toString()
    {
        String s = "";
        int k;

        k = 0;
        for ( int i = 0; i < 4; i++ )
        {
            for ( int j = 1; j <= 13; j++ ){
                s += ( deckOfCards[k++] + " " );
            }

            s += "\n";   // Add NEWLINE after 13 cards
        }
        return ( s );
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}

