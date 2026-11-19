# MG7
## Devlog
I created the TreeOfBirds script to make the sparrows appear when the player gets close to the tree. I used an array to store references to the Sparrow GameObjects, except Sparrow_Start. A loop checks each bird in the array to see if the player is nearby. Vectors are used to represent the positions of the player and birds in 3D space and calculate the distance between them. When the player is in the interaction distance of a bird, the bird becomes active. 

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
