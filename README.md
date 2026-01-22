### M5 Opdrachten

## Opdracht 1.1  
![opdracht1 1](https://github.com/user-attachments/assets/8e289f77-296a-4290-bcfe-b3d2ac44a676)  
**Script:** [SpawnBall.cs](https://github.com/MoKharbo/ProgPMO2B/blob/main/Assets/Scripts/opdr1.1-1.3/SpawnBall.cs)  

Een bal spawnt elke seconde op een random positie, en bij het starten van de game spawnen er direct 100 ballen.
ik heb een instantiate gebruikt en een for loop om het bal 100 keer te spawnen

---

## Opdracht 1.2  
![opdracht1 2](https://github.com/user-attachments/assets/0f8edbfe-d2f3-482b-b35f-94db8b238163)  
**Script:** [Tower.cs](https://github.com/MoKharbo/ProgPMO2B/blob/main/Assets/Scripts/opdr1.1-1.3/Tower.cs)  

Een toren spawnt op een random positie elke keer dat de spatiebalk wordt ingedrukt.
ik heb een instantiate gebruikt met random coordianten

---

## Opdracht 1.3  
![opdracht1 3](https://github.com/user-attachments/assets/c3e4d424-410c-42f8-9622-4ffcadf845c9)  
**Script:** [EnemySpawner.cs](https://github.com/MoKharbo/ProgPMO2B/blob/main/Assets/Scripts/opdr1.1-1.3/EnemySpawner.cs)  

Drie enemies spawnen elke 3 seconden en bewegen vooruit langs de Z-as.  
Wanneer je **W** indrukt, spawnen er 100 enemies.  
Wanneer je **Q** indrukt, verdwijnen alle enemies.
Ik heb een List gebruikt om de enemies te instantiaten

---

## Opdracht 2  
![opdracht2](https://github.com/user-attachments/assets/10aaa8fa-b849-4df7-a2e1-4db146e68ca4)  
**Scripts:**  
- [Pickup.cs](https://github.com/MoKharbo/ProgPMO2B/blob/main/Assets/Scripts/opdr2.1/Pickup.cs)  
- [Playermovement.cs](https://github.com/MoKharbo/ProgPMO2B/blob/main/Assets/Scripts/opdr2.1/Playermovement.cs)  
- [Scoreboard.cs](https://github.com/MoKharbo/ProgPMO2B/blob/main/Assets/Scripts/opdr2.1/Scoreboard.cs)  

Een speler die beweegt met **WASD** kan coins oppakken.  
Elke coin geeft **50 score** op het scoreboard.
Ik heb een Action Event moeten gebruiken voor het Score

---

## Opdracht 4
![shipopdracht4](https://github.com/user-attachments/assets/99cdcc2c-17ed-48f2-be08-c06d1fad5e4c)
**Scripts:**
- [Assets/Scripts/opdr4.1](https://github.com/MoKharbo/ProgPMO2B/tree/main/Assets/Scripts/opdr4.1)

Het ship kan bewegen en items oppakken en power ups krijgen.
Ik heb het script van Space Shooter genaamd ShipBehaviour gesplit naar meerdere scripts volgens het SRP ik heb een get en setter moeten gebruiken

---

## Opdracht 5  
![opdracht5af](https://github.com/user-attachments/assets/85015df7-b503-4728-9009-81877e57dc4c)  
**Scripts:**  
- [Elf.cs](https://github.com/MoKharbo/ProgPMO2B/blob/main/Assets/Scripts/Elf.cs)  
- [Brute.cs](https://github.com/MoKharbo/ProgPMO2B/blob/main/Assets/Scripts/Brute.cs)  
- [EnemyParent.cs](https://github.com/MoKharbo/ProgPMO2B/blob/main/Assets/Scripts/EnemyParent.cs)  

Een enemy loopt rond en kan worden neergeschoten en gedood.  
De **Elf** wordt elke 3 seconden **0.5 seconde onzichtbaar**.
ik heb overerfing gebruikt alles overerft van de EnemyParent class

---

### M6 Opdrachten

## Opdracht 1
![m6opdracht1](https://github.com/user-attachments/assets/c2bf3991-587a-41c9-9255-6af5da4298ad)
**Scripts:**
- Assets/Scripts/m6opdr1/opdr1/InventoryItem.cs
- Assets/Scripts/m6opdr1/opdr1/InventorySystem.cs

---

## Opdracht 3
![m6opdracht2](https://github.com/user-attachments/assets/3e7bf8c4-d4c2-4a66-8337-0287c8ce9de9)
**Scripts:**
- Assets/Scripts/m6opdr1/opdr3

---

## Opdracht 4
![m6opdracht4](https://github.com/user-attachments/assets/a18bc327-72e5-4cb0-91e9-4305d256dc4d)
**Scripts:**
- Assets/Scripts/m6opdr1/opdr4

---

## Opdracht 5
![m6opdracht5](https://github.com/user-attachments/assets/f44e4bb0-ad63-466c-994e-0f613f5afc92)
**Scripts:**
- Assets/Scripts/m6opdr1/opdr5

---

## Opdracht 6
![m6opdracht6](https://github.com/user-attachments/assets/271dbdf2-df56-4358-838c-c9ff81d5fd54)
**Scripts:**
- Assets/Scripts/m6opdr1/opdr6

---

## Opdracht 7

public bool IsPlayerReadyToAttack(Player player)
{
 if (player == null) return false;
 if (!player.IsAlive) return false;
 if (player.AttackCooldown >0) return false;

 if (player.Target == null) return false;
 if (!player.Target.IsAlive) return false;

float distance = Vector3.Distance(player.transform.position, player.Target.transform.position)
if (distance >= 5f) return false;

if (player.IsStunned) return false;
if (player.IsSlowed) return false;

bool hasManaAndWeapon
if (player.Mana >= 20 && player.WeaponEquipped)
        hasManaAndWeapon = true;

bool hasHealthAndBuff
if(player.Health > 30 && player.HasBuff("Strength"))
    hasHealthAndBuff = true;

if(!hasManaAndWeapon && !hasHealthAndBuff) return false;

    return True;
}
