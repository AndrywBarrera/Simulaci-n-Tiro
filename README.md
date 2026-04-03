<div align="center">

# 🎯 Tiro Parabólico — Simulador

**Simulación de Computadores · Universidad Pedagógica y Tecnológica de Colombia**  
Ingeniería de Sistemas y Computación

![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Estado](https://img.shields.io/badge/Estado-Entregado-28a745?style=for-the-badge)

</div>

---

## 📋 Descripción

Simulador interactivo de **movimiento parabólico** desarrollado en **C# Windows Forms** para el Taller 2 del primer corte de la asignatura Simulación de Computadores. El usuario arrastra un tejo (objeto) y lo lanza, observando en tiempo real la trayectoria, los cálculos cinemáticos y las gráficas del movimiento. El sistema incluye física de rebotes con pérdida de energía y detección de colisiones con obstáculo, objetivo y suelo.

---

## ✨ Características principales

### 📐 Punto 1 — Cálculos cinemáticos en tiempo real
Todos los valores se actualizan cuadro a cuadro durante la animación:

| Magnitud | Descripción |
|---|---|
| ⏱️ Tiempo de vuelo | Tiempo total acumulado desde el lanzamiento |
| 📏 Alcance máximo | Desplazamiento horizontal máximo (m) |
| 📈 Altura máxima | Pico de la trayectoria (m) |
| 🚀 Velocidad inicial | Vx₀, Vy₀, \|V₀\|, θ₀ |
| 🔝 Velocidad en altura máx. | Vx, Vy, \|V\|, θ cuando Vy cambia de signo |
| 🎯 Velocidad final al impacto | Vxf, Vyf, \|Vf\|, θf |

### 📊 Punto 2 — Gráficas (7 en total)

| Gráfica | Descripción |
|---|---|
| `y(t)` | Posición vertical en el tiempo |
| `x(t)` | Posición horizontal en el tiempo |
| `y(x)` | Trayectoria parabólica completa |
| `Vx(t)` | Componente horizontal de la velocidad |
| `Vy(t)` | Componente vertical de la velocidad |
| `\|V\|(t)` | Magnitud de la velocidad |
| `θ(t)` | Ángulo de la velocidad respecto al eje X |

> Cada rebote queda marcado con una ⭐ sobre todas las gráficas.

### 💥 Punto 3 — Física de rebotes

- El **obstáculo** tiene posición aleatoria en cada partida.
- Al caer sobre el **objetivo fijo**, el tejo rebota (1er rebote).
- Tras el objetivo, el tejo rebota **dos veces más** en el suelo antes de detenerse.
- Si el tejo golpea el **obstáculo lateral**, el vuelo termina de inmediato.
- Cada rebote **reduce Vx y Vy en un 40 %** (conserva el 60 % de la energía).
- Los datos cinemáticos de cada rebote se registran en el panel de estadísticas.

---

## 🏗️ Arquitectura del proyecto

```
TiroParabolico/
│
├── Program.cs              # Punto de entrada — lanza ProcessForm
│
├── ProcessForm.cs          # ⚙️  Formulario principal
│   ├── Física y cinemática (ecuaciones paraból.)
│   ├── Timer de animación
│   ├── Detección de colisiones
│   ├── Lógica de rebotes (FaseVuelo)
│   └── Actualización de labels en tiempo real
│
├── ProcessForm.Designer.cs # Controles del formulario principal (generado)
├── ProcessForm.resx        # Recursos del formulario principal
│
├── BackForm.cs             # 🖼️  Formulario de fondo (escenario visual)
│   └── Expone geometría de sprites para ProcessForm
│
├── BackForm.Designer.cs    # Sprites: tejo, suelo, obstáculo, objetivo (generado)
├── BackForm.resx           # Recursos del fondo
│
├── GraphForm.cs            # 📊  Formulario de gráficas (7 Charts)
│   ├── CargarDatos()       # API pública — recibe historiales
│   └── Marcadores de rebote en cada chart
│
├── GraphForm.Designer.cs   # Controles de las gráficas (generado)
│
└── App.config              # Configuración — .NET Framework 4.8
```

---

## 🔧 Requisitos

- **Visual Studio 2019 / 2022** (o superior)
- **.NET Framework 4.8**
- `System.Windows.Forms.DataVisualization.Charting` (incluido en .NET 4.x)
- Sistema operativo: **Windows**

---

## ▶️ Cómo ejecutar

1. Clona el repositorio:
   ```bash
   git clone https://github.com/Andryw/<nombre-del-repo>.git
   ```
2. Abre `TiroParabolico.sln` en Visual Studio.
3. Compila y ejecuta con **F5** o el botón ▶️ **Iniciar**.

---

## 🎮 Cómo usar

| Acción | Descripción |
|---|---|
| **Arrastrar el tejo** | Haz clic sobre el tejo y arrastra para apuntar |
| **Soltar el mouse** | Lanza el tejo con la velocidad del arrastre |
| **Botón Reiniciar** | Devuelve el tejo a la posición inicial y genera un nuevo obstáculo |
| **Botón Gráficas** | Muestra / oculta el formulario con las 7 gráficas |
| **Panel de cálculos** | Se despliega automáticamente al lanzar |

---

## 📐 Modelo físico

Las ecuaciones usadas en la simulación (por segmento de vuelo):

```
x(t) = x₀ + v₀ₓ · t
y(t) = y₀ + v₀ᵧ · t − ½ · g · t²

Vx(t) = v₀ₓ              (constante)
Vy(t) = v₀ᵧ − g · t

g = 9.8 px/s²    |    Escala: 1 px = 0.1 m
```

**Rebote (sobre objetivo o suelo):**
```
Vx_nuevo =  Vx · 0.6
Vy_nuevo = −Vy · 0.6    ← inversión + atenuación del 40 %
```

---

## 👨‍💻 Autores

| | |
|---|---|
| **Nombre** | Andryw Yesid Barrera Camargo |
| **Nombre** | David Leonardo Mariño Ardila |
| **Universidad** | Universidad Pedagógica y Tecnológica de Colombia |
| **Programa** | Ingeniería de Sistemas y Computación |
| **Asignatura** | Simulación de Computadores |
| **Entrega** | Taller 2 — Primer Corte (abril 2026) |

---

<div align="center">

*Hecho con 💙 en C# · UPTC Sogamoso*

</div>
