.class public Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;
.super Ljava/lang/Object;


# static fields
.field private static final PRIME1:I = -0x41e0eb4f

.field private static final PRIME2:I = -0x4b47d1c7

.field private static final PRIME3:I = -0x312e3dbf


# instance fields
.field capacity:I

.field private hashShift:I

.field keyTable:[Ljava/lang/Object;

.field private loadFactor:F

.field private mask:I

.field private pushIterations:I

.field public size:I

.field private stashCapacity:I

.field stashSize:I

.field private threshold:I

.field valueTable:[I


# direct methods
.method public constructor <init>()V
    .locals 2

    const/16 v0, 0x20

    const v1, 0x3f4ccccd    # 0.8f

    invoke-direct {p0, v0, v1}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;-><init>(IF)V

    return-void
.end method

.method public constructor <init>(I)V
    .locals 1

    const v0, 0x3f4ccccd    # 0.8f

    invoke-direct {p0, p1, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;-><init>(IF)V

    return-void
.end method

.method public constructor <init>(IF)V
    .locals 4

    invoke-direct {p0}, Ljava/lang/Object;-><init>()V

    if-gez p1, :cond_0

    new-instance v0, Ljava/lang/IllegalArgumentException;

    new-instance v1, Ljava/lang/StringBuilder;

    invoke-direct {v1}, Ljava/lang/StringBuilder;-><init>()V

    const-string v2, "initialCapacity must be >= 0: "

    invoke-virtual {v1, v2}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v1

    invoke-virtual {v1, p1}, Ljava/lang/StringBuilder;->append(I)Ljava/lang/StringBuilder;

    move-result-object v1

    invoke-virtual {v1}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v1

    invoke-direct {v0, v1}, Ljava/lang/IllegalArgumentException;-><init>(Ljava/lang/String;)V

    throw v0

    :cond_0
    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    const/high16 v1, 0x40000000    # 2.0f

    if-le v0, v1, :cond_1

    new-instance v0, Ljava/lang/IllegalArgumentException;

    new-instance v1, Ljava/lang/StringBuilder;

    invoke-direct {v1}, Ljava/lang/StringBuilder;-><init>()V

    const-string v2, "initialCapacity is too large: "

    invoke-virtual {v1, v2}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v1

    invoke-virtual {v1, p1}, Ljava/lang/StringBuilder;->append(I)Ljava/lang/StringBuilder;

    move-result-object v1

    invoke-virtual {v1}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v1

    invoke-direct {v0, v1}, Ljava/lang/IllegalArgumentException;-><init>(Ljava/lang/String;)V

    throw v0

    :cond_1
    invoke-static {p1}, Lcom/esotericsoftware/kryo/util/ObjectMap;->nextPowerOfTwo(I)I

    move-result v0

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    const/4 v0, 0x0

    cmpg-float v0, p2, v0

    if-gtz v0, :cond_2

    new-instance v0, Ljava/lang/IllegalArgumentException;

    new-instance v1, Ljava/lang/StringBuilder;

    invoke-direct {v1}, Ljava/lang/StringBuilder;-><init>()V

    const-string v2, "loadFactor must be > 0: "

    invoke-virtual {v1, v2}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    move-result-object v1

    invoke-virtual {v1, p2}, Ljava/lang/StringBuilder;->append(F)Ljava/lang/StringBuilder;

    move-result-object v1

    invoke-virtual {v1}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v1

    invoke-direct {v0, v1}, Ljava/lang/IllegalArgumentException;-><init>(Ljava/lang/String;)V

    throw v0

    :cond_2
    iput p2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->loadFactor:F

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    int-to-float v0, v0

    mul-float/2addr v0, p2

    float-to-int v0, v0

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    add-int/lit8 v0, v0, -0x1

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    invoke-static {v0}, Ljava/lang/Integer;->numberOfTrailingZeros(I)I

    move-result v0

    rsub-int/lit8 v0, v0, 0x1f

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hashShift:I

    const/4 v0, 0x3

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    int-to-double v2, v1

    invoke-static {v2, v3}, Ljava/lang/Math;->log(D)D

    move-result-wide v2

    invoke-static {v2, v3}, Ljava/lang/Math;->ceil(D)D

    move-result-wide v2

    double-to-int v1, v2

    mul-int/lit8 v1, v1, 0x2

    invoke-static {v0, v1}, Ljava/lang/Math;->max(II)I

    move-result v0

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashCapacity:I

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    const/16 v1, 0x8

    invoke-static {v0, v1}, Ljava/lang/Math;->min(II)I

    move-result v0

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    int-to-double v2, v1

    invoke-static {v2, v3}, Ljava/lang/Math;->sqrt(D)D

    move-result-wide v2

    double-to-int v1, v2

    div-int/lit8 v1, v1, 0x8

    invoke-static {v0, v1}, Ljava/lang/Math;->max(II)I

    move-result v0

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->pushIterations:I

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashCapacity:I

    add-int/2addr v0, v1

    new-array v0, v0, [Ljava/lang/Object;

    check-cast v0, [Ljava/lang/Object;

    iput-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    array-length v0, v0

    new-array v0, v0, [I

    iput-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    return-void
.end method

.method private containsKeyStash(Ljava/lang/Object;)Z
    .locals 4

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v2, v0

    :goto_0
    if-ge v0, v2, :cond_1

    aget-object v3, v1, v0

    if-ne p1, v3, :cond_0

    const/4 v0, 0x1

    :goto_1
    return v0

    :cond_0
    add-int/lit8 v0, v0, 0x1

    goto :goto_0

    :cond_1
    const/4 v0, 0x0

    goto :goto_1
.end method

.method private getAndIncrementStash(Ljava/lang/Object;II)I
    .locals 4

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v2, v0

    :goto_0
    if-ge v0, v2, :cond_1

    aget-object v3, v1, v0

    if-ne p1, v3, :cond_0

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aget p2, v1, v0

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    add-int v2, p2, p3

    aput v2, v1, v0

    :goto_1
    return p2

    :cond_0
    add-int/lit8 v0, v0, 0x1

    goto :goto_0

    :cond_1
    add-int v0, p2, p3

    invoke-virtual {p0, p1, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->put(Ljava/lang/Object;I)V

    goto :goto_1
.end method

.method private getStash(Ljava/lang/Object;I)I
    .locals 4

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v2, v0

    :goto_0
    if-ge v0, v2, :cond_0

    aget-object v3, v1, v0

    if-ne p1, v3, :cond_1

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aget p2, v1, v0

    :cond_0
    return p2

    :cond_1
    add-int/lit8 v0, v0, 0x1

    goto :goto_0
.end method

.method private hash2(I)I
    .locals 2

    const v0, -0x4b47d1c7

    mul-int/2addr v0, p1

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hashShift:I

    ushr-int v1, v0, v1

    xor-int/2addr v0, v1

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    and-int/2addr v0, v1

    return v0
.end method

.method private hash3(I)I
    .locals 2

    const v0, -0x312e3dbf

    mul-int/2addr v0, p1

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hashShift:I

    ushr-int v1, v0, v1

    xor-int/2addr v0, v1

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    and-int/2addr v0, v1

    return v0
.end method

.method private push(Ljava/lang/Object;IILjava/lang/Object;ILjava/lang/Object;ILjava/lang/Object;)V
    .locals 7

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget-object v3, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    iget v4, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    const/4 v0, 0x0

    iget v5, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->pushIterations:I

    :cond_0
    sget-object v1, Lcom/esotericsoftware/kryo/util/ObjectMap;->random:Ljava/util/Random;

    const/4 v6, 0x3

    invoke-virtual {v1, v6}, Ljava/util/Random;->nextInt(I)I

    move-result v1

    packed-switch v1, :pswitch_data_0

    aget v1, v3, p7

    aput-object p1, v2, p7

    aput p2, v3, p7

    move p2, v1

    move-object p1, p8

    :goto_0
    invoke-static {p1}, Ljava/lang/System;->identityHashCode(Ljava/lang/Object;)I

    move-result v1

    and-int p3, v1, v4

    aget-object p4, v2, p3

    if-nez p4, :cond_2

    aput-object p1, v2, p3

    aput p2, v3, p3

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v0, 0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    if-lt v0, v1, :cond_1

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    shl-int/lit8 v0, v0, 0x1

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    :cond_1
    :goto_1
    return-void

    :pswitch_0
    aget v1, v3, p3

    aput-object p1, v2, p3

    aput p2, v3, p3

    move p2, v1

    move-object p1, p4

    goto :goto_0

    :pswitch_1
    aget v1, v3, p5

    aput-object p1, v2, p5

    aput p2, v3, p5

    move p2, v1

    move-object p1, p6

    goto :goto_0

    :cond_2
    invoke-direct {p0, v1}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash2(I)I

    move-result p5

    aget-object p6, v2, p5

    if-nez p6, :cond_3

    aput-object p1, v2, p5

    aput p2, v3, p5

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v0, 0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    if-lt v0, v1, :cond_1

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    shl-int/lit8 v0, v0, 0x1

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    goto :goto_1

    :cond_3
    invoke-direct {p0, v1}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash3(I)I

    move-result p7

    aget-object p8, v2, p7

    if-nez p8, :cond_4

    aput-object p1, v2, p7

    aput p2, v3, p7

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v0, 0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    if-lt v0, v1, :cond_1

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    shl-int/lit8 v0, v0, 0x1

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    goto :goto_1

    :cond_4
    add-int/lit8 v0, v0, 0x1

    if-ne v0, v5, :cond_0

    invoke-direct {p0, p1, p2}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->putStash(Ljava/lang/Object;I)V

    goto :goto_1

    nop

    :pswitch_data_0
    .packed-switch 0x0
        :pswitch_0
        :pswitch_1
    .end packed-switch
.end method

.method private putResize(Ljava/lang/Object;I)V
    .locals 9

    invoke-static {p1}, Ljava/lang/System;->identityHashCode(Ljava/lang/Object;)I

    move-result v0

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    and-int v3, v0, v1

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v4, v1, v3

    if-nez v4, :cond_1

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aput-object p1, v0, v3

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v0, v3

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v0, 0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    if-lt v0, v1, :cond_0

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    shl-int/lit8 v0, v0, 0x1

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    :cond_0
    :goto_0
    return-void

    :cond_1
    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash2(I)I

    move-result v5

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v6, v1, v5

    if-nez v6, :cond_2

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aput-object p1, v0, v5

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v0, v5

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v0, 0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    if-lt v0, v1, :cond_0

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    shl-int/lit8 v0, v0, 0x1

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    goto :goto_0

    :cond_2
    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash3(I)I

    move-result v7

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v8, v0, v7

    if-nez v8, :cond_3

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aput-object p1, v0, v7

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v0, v7

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v0, 0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    if-lt v0, v1, :cond_0

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    shl-int/lit8 v0, v0, 0x1

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    goto :goto_0

    :cond_3
    move-object v0, p0

    move-object v1, p1

    move v2, p2

    invoke-direct/range {v0 .. v8}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->push(Ljava/lang/Object;IILjava/lang/Object;ILjava/lang/Object;ILjava/lang/Object;)V

    goto :goto_0
.end method

.method private putStash(Ljava/lang/Object;I)V
    .locals 2

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashCapacity:I

    if-ne v0, v1, :cond_0

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    shl-int/lit8 v0, v0, 0x1

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    invoke-virtual {p0, p1, p2}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->put(Ljava/lang/Object;I)V

    :goto_0
    return-void

    :cond_0
    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v0, v1

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aput-object p1, v1, v0

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v1, v0

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/lit8 v0, v0, 0x1

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v0, v0, 0x1

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    goto :goto_0
.end method

.method private resize(I)V
    .locals 6

    const/4 v1, 0x0

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v2, v0

    iput p1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    int-to-float v0, p1

    iget v3, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->loadFactor:F

    mul-float/2addr v0, v3

    float-to-int v0, v0

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    add-int/lit8 v0, p1, -0x1

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    invoke-static {p1}, Ljava/lang/Integer;->numberOfTrailingZeros(I)I

    move-result v0

    rsub-int/lit8 v0, v0, 0x1f

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hashShift:I

    const/4 v0, 0x3

    int-to-double v4, p1

    invoke-static {v4, v5}, Ljava/lang/Math;->log(D)D

    move-result-wide v4

    invoke-static {v4, v5}, Ljava/lang/Math;->ceil(D)D

    move-result-wide v4

    double-to-int v3, v4

    mul-int/lit8 v3, v3, 0x2

    invoke-static {v0, v3}, Ljava/lang/Math;->max(II)I

    move-result v0

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashCapacity:I

    const/16 v0, 0x8

    invoke-static {p1, v0}, Ljava/lang/Math;->min(II)I

    move-result v0

    int-to-double v4, p1

    invoke-static {v4, v5}, Ljava/lang/Math;->sqrt(D)D

    move-result-wide v4

    double-to-int v3, v4

    div-int/lit8 v3, v3, 0x8

    invoke-static {v0, v3}, Ljava/lang/Math;->max(II)I

    move-result v0

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->pushIterations:I

    iget-object v3, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget-object v4, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashCapacity:I

    add-int/2addr v0, p1

    new-array v0, v0, [Ljava/lang/Object;

    check-cast v0, [Ljava/lang/Object;

    iput-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashCapacity:I

    add-int/2addr v0, p1

    new-array v0, v0, [I

    iput-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    move v0, v1

    :goto_0
    if-ge v0, v2, :cond_1

    aget-object v1, v3, v0

    if-eqz v1, :cond_0

    aget v5, v4, v0

    invoke-direct {p0, v1, v5}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->putResize(Ljava/lang/Object;I)V

    :cond_0
    add-int/lit8 v0, v0, 0x1

    goto :goto_0

    :cond_1
    return-void
.end method


# virtual methods
.method public clear()V
    .locals 4

    const/4 v3, 0x0

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v0, v1

    :goto_0
    add-int/lit8 v1, v0, -0x1

    if-lez v0, :cond_0

    const/4 v0, 0x0

    aput-object v0, v2, v1

    move v0, v1

    goto :goto_0

    :cond_0
    iput v3, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iput v3, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    return-void
.end method

.method public containsKey(Ljava/lang/Object;)Z
    .locals 3

    invoke-static {p1}, Ljava/lang/System;->identityHashCode(Ljava/lang/Object;)I

    move-result v0

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    and-int/2addr v1, v0

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v1, v2, v1

    if-eq p1, v1, :cond_0

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash2(I)I

    move-result v1

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v1, v2, v1

    if-eq p1, v1, :cond_0

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash3(I)I

    move-result v0

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v0, v1, v0

    if-eq p1, v0, :cond_0

    invoke-direct {p0, p1}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->containsKeyStash(Ljava/lang/Object;)Z

    move-result v0

    :goto_0
    return v0

    :cond_0
    const/4 v0, 0x1

    goto :goto_0
.end method

.method public containsValue(I)Z
    .locals 3

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v0, v1

    :goto_0
    add-int/lit8 v1, v0, -0x1

    if-lez v0, :cond_0

    aget v0, v2, v1

    if-ne v0, p1, :cond_1

    const/4 v0, 0x1

    :goto_1
    return v0

    :cond_0
    const/4 v0, 0x0

    goto :goto_1

    :cond_1
    move v0, v1

    goto :goto_0
.end method

.method public ensureCapacity(I)V
    .locals 2

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/2addr v0, p1

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    if-lt v0, v1, :cond_0

    int-to-float v0, v0

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->loadFactor:F

    div-float/2addr v0, v1

    float-to-int v0, v0

    invoke-static {v0}, Lcom/esotericsoftware/kryo/util/ObjectMap;->nextPowerOfTwo(I)I

    move-result v0

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    :cond_0
    return-void
.end method

.method public findKey(I)Ljava/lang/Object;
    .locals 3

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v0, v1

    :goto_0
    add-int/lit8 v1, v0, -0x1

    if-lez v0, :cond_0

    aget v0, v2, v1

    if-ne v0, p1, :cond_1

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v0, v0, v1

    :goto_1
    return-object v0

    :cond_0
    const/4 v0, 0x0

    goto :goto_1

    :cond_1
    move v0, v1

    goto :goto_0
.end method

.method public get(Ljava/lang/Object;I)I
    .locals 3

    invoke-static {p1}, Ljava/lang/System;->identityHashCode(Ljava/lang/Object;)I

    move-result v1

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    and-int/2addr v0, v1

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v2, v2, v0

    if-eq p1, v2, :cond_0

    invoke-direct {p0, v1}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash2(I)I

    move-result v0

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v2, v2, v0

    if-eq p1, v2, :cond_0

    invoke-direct {p0, v1}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash3(I)I

    move-result v0

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v1, v1, v0

    if-eq p1, v1, :cond_0

    invoke-direct {p0, p1, p2}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->getStash(Ljava/lang/Object;I)I

    move-result v0

    :goto_0
    return v0

    :cond_0
    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aget v0, v1, v0

    goto :goto_0
.end method

.method public getAndIncrement(Ljava/lang/Object;II)I
    .locals 4

    invoke-static {p1}, Ljava/lang/System;->identityHashCode(Ljava/lang/Object;)I

    move-result v1

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    and-int/2addr v0, v1

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v2, v2, v0

    if-eq p1, v2, :cond_0

    invoke-direct {p0, v1}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash2(I)I

    move-result v0

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v2, v2, v0

    if-eq p1, v2, :cond_0

    invoke-direct {p0, v1}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash3(I)I

    move-result v0

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v1, v1, v0

    if-eq p1, v1, :cond_0

    invoke-direct {p0, p1, p2, p3}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->getAndIncrementStash(Ljava/lang/Object;II)I

    move-result v0

    :goto_0
    return v0

    :cond_0
    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aget v1, v1, v0

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    add-int v3, v1, p3

    aput v3, v2, v0

    move v0, v1

    goto :goto_0
.end method

.method public put(Ljava/lang/Object;I)V
    .locals 10

    if-nez p1, :cond_0

    new-instance v0, Ljava/lang/IllegalArgumentException;

    const-string v1, "key cannot be null."

    invoke-direct {v0, v1}, Ljava/lang/IllegalArgumentException;-><init>(Ljava/lang/String;)V

    throw v0

    :cond_0
    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    invoke-static {p1}, Ljava/lang/System;->identityHashCode(Ljava/lang/Object;)I

    move-result v0

    iget v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    and-int v3, v0, v2

    aget-object v4, v1, v3

    if-ne p1, v4, :cond_2

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v0, v3

    :cond_1
    :goto_0
    return-void

    :cond_2
    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash2(I)I

    move-result v5

    aget-object v6, v1, v5

    if-ne p1, v6, :cond_3

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v0, v5

    goto :goto_0

    :cond_3
    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash3(I)I

    move-result v7

    aget-object v8, v1, v7

    if-ne p1, v8, :cond_4

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v0, v7

    goto :goto_0

    :cond_4
    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v2, v0

    :goto_1
    if-ge v0, v2, :cond_6

    aget-object v9, v1, v0

    if-ne v9, p1, :cond_5

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v1, v0

    goto :goto_0

    :cond_5
    add-int/lit8 v0, v0, 0x1

    goto :goto_1

    :cond_6
    if-nez v4, :cond_7

    aput-object p1, v1, v3

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v0, v3

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v0, 0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    if-lt v0, v1, :cond_1

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    shl-int/lit8 v0, v0, 0x1

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    goto :goto_0

    :cond_7
    if-nez v6, :cond_8

    aput-object p1, v1, v5

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v0, v5

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v0, 0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    if-lt v0, v1, :cond_1

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    shl-int/lit8 v0, v0, 0x1

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    goto :goto_0

    :cond_8
    if-nez v8, :cond_9

    aput-object p1, v1, v7

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aput p2, v0, v7

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v0, 0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->threshold:I

    if-lt v0, v1, :cond_1

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    shl-int/lit8 v0, v0, 0x1

    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->resize(I)V

    goto :goto_0

    :cond_9
    move-object v0, p0

    move-object v1, p1

    move v2, p2

    invoke-direct/range {v0 .. v8}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->push(Ljava/lang/Object;IILjava/lang/Object;ILjava/lang/Object;ILjava/lang/Object;)V

    goto/16 :goto_0
.end method

.method public remove(Ljava/lang/Object;I)I
    .locals 4

    const/4 v3, 0x0

    invoke-static {p1}, Ljava/lang/System;->identityHashCode(Ljava/lang/Object;)I

    move-result v0

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->mask:I

    and-int/2addr v1, v0

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v2, v2, v1

    if-ne p1, v2, :cond_0

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aput-object v3, v0, v1

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aget v0, v0, v1

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v1, -0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    :goto_0
    return v0

    :cond_0
    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash2(I)I

    move-result v1

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v2, v2, v1

    if-ne p1, v2, :cond_1

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aput-object v3, v0, v1

    iget-object v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aget v0, v0, v1

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v1, -0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    goto :goto_0

    :cond_1
    invoke-direct {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->hash3(I)I

    move-result v0

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v1, v1, v0

    if-ne p1, v1, :cond_2

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aput-object v3, v1, v0

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aget v0, v1, v0

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v1, v1, -0x1

    iput v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    goto :goto_0

    :cond_2
    invoke-virtual {p0, p1, p2}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->removeStash(Ljava/lang/Object;I)I

    move-result v0

    goto :goto_0
.end method

.method removeStash(Ljava/lang/Object;I)I
    .locals 4

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v2, v0

    :goto_0
    if-ge v0, v2, :cond_0

    aget-object v3, v1, v0

    if-ne p1, v3, :cond_1

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aget p2, v1, v0

    invoke-virtual {p0, v0}, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->removeStashIndex(I)V

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    add-int/lit8 v0, v0, -0x1

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    :cond_0
    return p2

    :cond_1
    add-int/lit8 v0, v0, 0x1

    goto :goto_0
.end method

.method removeStashIndex(I)V
    .locals 3

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/lit8 v0, v0, -0x1

    iput v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->capacity:I

    iget v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->stashSize:I

    add-int/2addr v0, v1

    if-ge p1, v0, :cond_0

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    aget-object v2, v2, v0

    aput-object v2, v1, p1

    iget-object v1, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    iget-object v2, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    aget v0, v2, v0

    aput v0, v1, p1

    :cond_0
    return-void
.end method

.method public toString()Ljava/lang/String;
    .locals 7

    const/16 v6, 0x3d

    iget v0, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->size:I

    if-nez v0, :cond_0

    const-string v0, "{}"

    :goto_0
    return-object v0

    :cond_0
    new-instance v2, Ljava/lang/StringBuilder;

    const/16 v0, 0x20

    invoke-direct {v2, v0}, Ljava/lang/StringBuilder;-><init>(I)V

    const/16 v0, 0x7b

    invoke-virtual {v2, v0}, Ljava/lang/StringBuilder;->append(C)Ljava/lang/StringBuilder;

    iget-object v3, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->keyTable:[Ljava/lang/Object;

    iget-object v4, p0, Lcom/esotericsoftware/kryo/util/IdentityObjectIntMap;->valueTable:[I

    array-length v0, v3

    move v1, v0

    :goto_1
    add-int/lit8 v0, v1, -0x1

    if-lez v1, :cond_2

    aget-object v1, v3, v0

    if-nez v1, :cond_1

    move v1, v0

    goto :goto_1

    :cond_1
    invoke-virtual {v2, v1}, Ljava/lang/StringBuilder;->append(Ljava/lang/Object;)Ljava/lang/StringBuilder;

    invoke-virtual {v2, v6}, Ljava/lang/StringBuilder;->append(C)Ljava/lang/StringBuilder;

    aget v1, v4, v0

    invoke-virtual {v2, v1}, Ljava/lang/StringBuilder;->append(I)Ljava/lang/StringBuilder;

    :cond_2
    :goto_2
    add-int/lit8 v1, v0, -0x1

    if-lez v0, :cond_4

    aget-object v0, v3, v1

    if-nez v0, :cond_3

    move v0, v1

    goto :goto_2

    :cond_3
    const-string v5, ", "

    invoke-virtual {v2, v5}, Ljava/lang/StringBuilder;->append(Ljava/lang/String;)Ljava/lang/StringBuilder;

    invoke-virtual {v2, v0}, Ljava/lang/StringBuilder;->append(Ljava/lang/Object;)Ljava/lang/StringBuilder;

    invoke-virtual {v2, v6}, Ljava/lang/StringBuilder;->append(C)Ljava/lang/StringBuilder;

    aget v0, v4, v1

    invoke-virtual {v2, v0}, Ljava/lang/StringBuilder;->append(I)Ljava/lang/StringBuilder;

    move v0, v1

    goto :goto_2

    :cond_4
    const/16 v0, 0x7d

    invoke-virtual {v2, v0}, Ljava/lang/StringBuilder;->append(C)Ljava/lang/StringBuilder;

    invoke-virtual {v2}, Ljava/lang/StringBuilder;->toString()Ljava/lang/String;

    move-result-object v0

    goto :goto_0
.end method
