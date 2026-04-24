<div align="center">
  <h1>🏎️ Modular Car & Engine Factory Design</h1>
  <p>A C# implementation of a highly modular car manufacturing system. This project demonstrates advanced Object-Oriented Programming (OOP) concepts,
    including abstract classes, generic constraints, and composite logic for hybrid systems.</p>
</div>

<hr />

<h3>📌 Project Overview</h3>
<p>
  This system is designed around the concept of <b>Interchangeable Engines</b>. A Car can have its engine swapped at runtime, and the factory uses generics to produce specific engine types on demand.
</p>

<h3>🛠️ Key Requirements Implemented</h3>
<ul>
  <li>
    <b>Encapsulated Speed Logic:</b> The Car handles high-level speed (20 km/h increments), while the Engine handles internal cycles (1 km/h increments).
  </li>
  <li>
    <b>Smart Hybrid System:</b> <code>HybridEngine</code> automatically toggles between Electric and Gasoline based on a 50 km/h threshold for cost optimization.
  </li>
  <li>
    <b>Generic Factory:</b> A centralized factory system to instantiate engines and cars without tight coupling.
  </li>
</ul>

<hr />

<h3>📂 Project Structure</h3>
<pre>
├── Abstractions/
│   └── Engine.cs            # Abstract base class for all engine types
├── ConcreteClasses/
│   ├── Car.cs               # Main Car entity
│   ├── GasEngine.cs         # Gas implementation
│   ├── ElectricEngine.cs    # Electric implementation
│   └── HybridEngine.cs      # Hybrid logic (Composite)
├── Factories/
    ├── EngineFactory.cs     # Generic engine creator
    └── CarFactory.cs        # Car creator

</pre>

<hr />
