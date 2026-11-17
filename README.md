# MG7
## Devlog
My TreeOfBirds script is attached to the Tree. It uses an array called _birds to keep track of all the birds in the tree. In Update(), a for loop checks each bird every frame. For each bird, I use Vector3.Distance() to get the distance between the player and that bird. Each position is a Vector3 with x, y, and z values. If the distance is less than or equal to the interaction distance, the script calls SetActive(true) on the bird, so the bird pops out of the tree.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
