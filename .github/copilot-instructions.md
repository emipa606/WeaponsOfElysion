## GitHub Copilot Instructions for Weapons Of Elysion (Continued) Mod

### Mod Overview and Purpose

Weapons Of Elysion (Continued) is a RimWorld mod that introduces two new weapons: the Voltaic Hand-Cannon and the High Explosive Combat Rifle. The mod is a continuation of the original Weapons Of Elysion mod by MercuryDoll and Yaluzan. The primary purpose of the mod is to enhance the gameplay experience by introducing new weapons with unique mechanics and abilities.

### Key Features and Systems

1. **Voltaic Hand-Cannon**: A lightning-based shotgun that deals fire and EMP damage. Each shot releases multiple lightning bolts that burn and disable nearby enemies.

2. **High Explosive Combat Rifle**: A rifle with explosive bullets that cause a small but powerful explosion upon impact. The weapon has poor accuracy and a long cooldown period, making it a specialized weapon for taking out tough targets.

### Coding Patterns and Conventions

1. **C# Coding Conventions**: Follow the RimWorld coding conventions, which include using PascalCase for method and property names, camelCase for local variables, and ensuring proper documentation and comments.

2. **XML Integration**: Use XML files to define new game elements, such as weapons, sound effects, and damage types. Ensure that XML files are correctly structured and compatible with the RimWorld game engine.

3. **Harmony Patching**: Utilize the Harmony library to patch existing game code to add new functionality or modify existing behavior. Follow best practices for writing Harmony patches, including avoiding conflicts with other mods and ensuring that patches are properly tested.

### XML Integration

1. **SoundDefs**: Define new sound effects using the `SoundDef` element in XML files. Ensure that sound files are correctly referenced and that sound effects are properly integrated into the game.

2. **ThingDefs**: Define new weapons using the `ThingDef` element in XML files. Specify properties such as damage type, range, and accuracy. Ensure that weapon definitions are correctly integrated into the game and that weapons behave as expected.

### Harmony Patching

1. **Patching Game Code**: Use Harmony patches to modify existing game code to add new functionality or modify existing behavior. Follow best practices for writing Harmony patches, including avoiding conflicts with other mods and ensuring that patches are properly tested.

2. **Avoiding Conflicts**: Ensure that Harmony patches do not conflict with other mods or existing game code. Use unique patch identifiers and thoroughly test patches before deploying them to the mod.

### Suggestions for Copilot

1. **Generating XML Definitions**: Use Copilot to generate XML definitions for new game elements, such as weapons, sound effects, and damage types. Ensure that generated XML files are correctly structured and compatible with the RimWorld game engine.

2. **Writing Harmony Patches**: Use Copilot to generate Harmony patches for modifying existing game code. Follow best practices for writing Harmony patches, including avoiding conflicts with other mods and ensuring that patches are properly tested.

3. **Generating C# Code**: Use Copilot to generate C# code for new game elements, such as custom bullet types and damage effects. Ensure that generated C# code follows the RimWorld coding conventions and is properly integrated into the game.

4. **Providing Documentation**: Use Copilot to generate documentation for new game elements, such as weapons, sound effects, and damage types. Ensure that documentation is clear and concise, and provides sufficient information for modders to use the new game elements effectively.

By following these guidelines and utilizing GitHub Copilot, modders can quickly and efficiently develop new game elements and functionality for the Weapons Of Elysion (Continued) mod.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

