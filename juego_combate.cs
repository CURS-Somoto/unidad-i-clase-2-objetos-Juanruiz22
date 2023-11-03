class Guerrero:

    def __init__(self, vida, nivelAtaque, nombre):
        self.vida = vida
        self.nivelAtaque = nivelAtaque
        self.nombre = nombre

    def ataque(self):
        return self.nivelAtaque

    def recibeAtaque(self, ataque):
        self.vida -= ataque

# Clase Enfrentamiento
class Enfrentamiento:

    def iniciar(self, guerrero1, guerrero2):
        print("¡Comienza el enfrentamiento!")
        while guerrero1.vida > 0 and guerrero2.vida > 0:
            ataque1 = guerrero1.ataque()
            guerrero2.recibeAtaque(ataque1)
            print(f"{guerrero1.nombre} ataca a {guerrero2.nombre} con {ataque1} puntos de daño.")
            ataque2 = guerrero2.ataque()
            guerrero1.recibeAtaque(ataque2)
            print(f"{guerrero2.nombre} ataca a {guerrero1.nombre} con {ataque2} puntos de daño.")

        if guerrero1.vida <= 0:
            print(f"El ganador es {guerrero2.nombre}!")
        else:
            print(f"El ganador es {guerrero1.nombre}!")

# Instanciación de guerreros
guerrero1 = Guerrero(100, 20, "Guerrero 1")
guerrero2 = Guerrero(100, 30, "Guerrero 2")

# Instanciación de enfrentamiento
enfrentamiento = Enfrentamiento()

# Inicio del enfrentamiento
enfrentamiento.iniciar(guerrero1, guerrero2)
